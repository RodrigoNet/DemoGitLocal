Public Class Facturas
    Dim RUT As New BC.RUTman
    Private TotalDescuentoPorcentaje As Long = 0
    Private TotalDescuento As Long = 0

    Private Sub Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTESISTEMDataSet.FormaDePago' table. You can move, or remove it, as needed.
        Me.FormaDePagoTableAdapter.Fill(Me.DTESISTEMDataSet.FormaDePago)
        Me.uic_Formapago.SelectedIndex = -1
        uic_FechaEmision.Value = Now
    End Sub

    Private Sub uic_FechaEmision_KeyPress(sender As Object, e As KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.uic_rut.Focus()
        End If
    End Sub

    Sub Buscar_Cliente()
        Dim rut As String
        Dim sql As New dac.myhelper3
        Dim cliente As New DataTable
        rut = Me.uic_rut.Text.Trim
        cliente = sql.ExecuteDataSet(My.Settings.facturaConnectionString, CommandType.Text, "select * from Clientes where RutCliente='" & rut & "'", Nothing, 60).Tables(0)
        If cliente.Rows.Count > 0 Then
            uic_RazonSocial.Text = cliente.Rows(0).Item("RazonSocialCliente")
        Else
            MsgBox("Deber crear Cliente", vbInformation, "Aviso")
            Clientes.uic_RUT.Text = Me.uic_rut.Text
            Clientes.ShowDialog()
        End If
    End Sub
    Private Sub uic_buscarCliente_Click(sender As Object, e As EventArgs) Handles uic_buscarCliente.Click
        Dim fr As New BuscarClientes
        fr.ShowDialog()
    End Sub
    Private Sub uic_RazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_RazonSocial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            Me.uic_Formapago.Focus()
        End If
    End Sub
    Private Sub uic_rut_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_rut.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            If Not RUT.check_es_valido(Me.uic_rut.Text) Then
                MsgBox("Error, RUT no valido", MsgBoxStyle.Critical, "Error")
                Me.uic_rut.Focus()
                Exit Sub
            End If
            Buscar_Cliente()
            'buscar_folio()
            Me.uic_RazonSocial.Focus()
        End If
    End Sub
    Private Sub uic_AgregarDetalle_Click(sender As Object, e As EventArgs) Handles uic_AgregarDetalle.Click
        If Me.uic_Producto.Text = "" Then
            Exit Sub
        End If
        Dim total As Integer = Val(Me.uic_Cantidad.Text.Trim) * Val(Me.uic_Precio.Text.Trim)
        Me.uic_GridDetalle.Rows.Add(Me.uic_CodigoProducto.Text.Trim, Me.uic_Producto.Text.Trim, Me.uic_UM.Text.Trim, Me.uic_Cantidad.Text.Trim, Me.uic_Precio.Text.Trim, total, "Eliminar")
        Me.uic_CodigoProducto.Focus()
        CalculoTotal()
        limpiarDetalle()
    End Sub

    Private Sub uic_GridDetalle_Click(sender As Object, e As EventArgs) Handles uic_GridDetalle.Click
       
    End Sub

    Private Sub CalculoTotal()
        Dim descuento As Integer = 0
        Dim recargo As Integer = 0

        Dim neto As Integer = 0
        Dim iva As Integer = 0
        Dim total_Doc As Integer = 0
        For i As Integer = 0 To Me.uic_GridDetalle.Rows.Count - 1
            neto = neto + uic_GridDetalle.Rows(i).Cells(5).Value
        Next
        If Me.uic_TotalDescuento.Text <> "" Then
            descuento = CInt(uic_TotalDescuento.Text)
        End If
        If Me.uic_TotalRecargo.Text <> "" Then
            recargo = CInt(Me.uic_TotalRecargo.Text)
        End If
        Dim totalNeto = neto - descuento + recargo
        Me.uic_Neto.Text = totalNeto
        If totalNeto = 0 Then
            Me.uic_IVA.Text = "0"
            total_Doc = 0
        Else
            iva = ((totalNeto * 19) / 100) '+ 0.5
            total_Doc = totalNeto + iva
        End If
        Me.uic_IVA.Text = iva
        Me.uic_Total_Doc.Text = total_Doc
    End Sub
    Private Sub LimpiarDetalle()
        Me.uic_CodigoProducto.Text = ""
        Me.uic_Producto.Text = ""
        Me.uic_Cantidad.Text = ""
        Me.uic_Precio.Text = ""
        Me.uic_UM.Text = ""
    End Sub

    Private Sub uic_CodigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            'SendKeys.Send("{TAB}")
            Buscar_articulo_venta()

            'Me.uic_Cantidad.Focus()
        End If
    End Sub
    Sub Buscar_articulo_venta()
        Dim buscar As String
        Dim articulo As New DataTable
        Dim odac As New dac.myhelper3
        buscar = Me.uic_CodigoProducto.Text
        articulo = odac.ExecuteDataSet(My.Settings.DTESISTEMConnectionString, CommandType.Text, "SELECT p.CodProducto, p.Descripcion, p.InfoAdic, p.UM, p.Exento, p.CodImpuestoAdic1, p.CodImpuestoAdic2, p.TasaImpAdic1, p.TasaImpAdic2, p.Precio FROM Producto AS p INNER JOIN Cod_Barra AS cb ON p.CodProducto = cb.CodProducto WHERE cb.CodBarra='" & buscar & "'", Nothing, 60).Tables(0)

        If articulo.Rows.Count > 0 Then
            Me.uic_Producto.Text = articulo.Rows(0).Item("descripcion").trim
            Me.uic_UM.Text = articulo.Rows(0).Item("UM").trim
            Me.uic_Precio.Text = CInt(articulo.Rows(0).Item("precio"))
            Me.uic_Cantidad.Focus()
        Else
            Me.uic_CodigoProducto.Focus()
            MsgBox("No existe codigo producto", vbInformation, "Aviso")

        End If
    End Sub
    Private Sub uic_BuscarProducto_Click(sender As Object, e As EventArgs) Handles uic_BuscarProducto.Click
        Dim fr As New BuscarProducto
        fr.ShowDialog()
        Me.uic_Cantidad.Focus()
    End Sub
    Private Sub uic_Cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Cantidad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        Else
            If e.KeyChar < "0" Or e.KeyChar > "9" Then
                If e.KeyChar <> Chr(8) Then
                    e.KeyChar = Chr(0)
                End If
            End If
        End If
    End Sub
    Private Sub uic_AgregaDescuento_Click(sender As Object, e As EventArgs) Handles uic_AgregaDescuento.Click
        If Me.uic_ValorDescuento.Text = "" Or Me.uic_ValorDescuento.Text = "0" Then
            Exit Sub
        End If
        Dim DscExento As Integer = 0
        Dim tipoDsc As String = "$"
        Dim TpoMov As String = "D"

        If Me.Chk_Exento.CheckState = 1 And (Me.uic_montoExento.Text = "0" Or Me.uic_montoExento.Text = "") Then
            MsgBox("No hay valor exento", vbInformation, "Alerta")
            Me.Chk_Exento.CheckState = False
            Exit Sub
        End If
        If Me.uic_Porciento.CheckState = 1 And CInt(Me.uic_ValorDescuento.Text) > 100 Then
            MsgBox("Valor porciento supera el 100%", vbInformation, "Alerta")
            Exit Sub
        End If
        If Me.uic_Porciento.CheckState Then
            tipoDsc = "%"
        End If
        If Me.Chk_Exento.CheckState Then
            DscExento = 1
        End If
        If Me.uic_Recargo.CheckState Then
            TpoMov = "R"
        End If

        Me.uic_GrillaDescuento.Rows.Add(TpoMov, Me.uic_ValorDescuento.Text, Me.uic_RazonDescuento.Text.Trim, tipoDsc, DscExento, "Eliminar")
        CalculoDescuento()
        CalculoTotal()
        LimpiarDescuento()
    End Sub
    Private Sub LimpiarDescuento()
        Me.uic_ValorDescuento.Text = ""
        Me.uic_Porciento.CheckState = False
        Me.Chk_Exento.CheckState = False
        Me.uic_RazonDescuento.Text = ""
        Me.uic_Recargo.CheckState = False
    End Sub
    Private Sub CalculoDescuento()
        Dim TotalRecargo As Long = 0
        TotalDescuento = 0
        For x = 0 To Me.uic_GrillaDescuento.Rows.Count - 1
            If Me.uic_GrillaDescuento.Rows(x).Cells(0).Value = "D" Then
                If Me.uic_GrillaDescuento.Rows(x).Cells(3).Value = "%" Then
                    TotalDescuentoPorcentaje += Me.uic_GrillaDescuento.Rows(x).Cells(1).Value
                Else
                    TotalDescuento += Me.uic_GrillaDescuento.Rows(x).Cells(1).Value
                End If
            Else
                TotalRecargo += Me.uic_GrillaDescuento.Rows(x).Cells(1).Value
            End If
        Next
        If Me.uic_GrillaDescuento.Rows.Count = 0 Then
            TotalRecargo = 0
            TotalDescuento = 0
            TotalDescuentoPorcentaje = 0
            Me.uic_TotalDescuento.Text = "0"
            CalculoTotal()
        Else
            If TotalDescuento > 0 Then
                Me.uic_TotalDescuento.Text = TotalDescuento
            End If
            If TotalDescuentoPorcentaje > 0 Then
                Me.uic_TotalDescuento.Text = Val(Me.uic_Neto.Text) * TotalDescuentoPorcentaje / 100
            End If
            Me.uic_TotalRecargo.Text = TotalRecargo
        End If
        
    End Sub
    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub
    Private Sub uic_Limpiar_Click(sender As Object, e As EventArgs) Handles uic_Limpiar.Click
        Limpiar()
    End Sub
    Private Sub Limpiar()
        Me.uic_rut.Text = ""
        Me.uic_RazonSocial.Text = ""
        Me.uic_Formapago.SelectedIndex = -1
        Me.uic_Vendedor.SelectedIndex = -1
        Me.uic_GridDetalle.Rows.Clear()
        Me.uic_GridDetalle.Rows.Clear()
        Me.uic_TotalDescuento.Text = "0"
        Me.uic_TotalRecargo.Text = "0"
        Me.uic_montoExento.Text = "0"
        Me.uic_Neto.Text = "0"
        Me.uic_IVA.Text = "0"
        Me.uic_Total_Doc.Text = "0"
    End Sub
    Private Sub uic_GridDetalle_CommandCellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles uic_GridDetalle.CommandCellClick
        Try
            If Me.uic_GridDetalle.Columns.Contains("Eliminar") Then
                Dim pos As Integer = uic_GridDetalle.Rows.IndexOf(uic_GridDetalle.CurrentRow)
                uic_GridDetalle.Rows.RemoveAt(pos)
                CalculoTotal()
            End If
        Catch ex As Exception
        End Try
    End Sub
    Private Sub uic_GrillaDescuento_CommandCellClick(sender As Object, e As Telerik.WinControls.UI.GridViewCellEventArgs) Handles uic_GrillaDescuento.CommandCellClick
        Try
            If Me.uic_GrillaDescuento.Columns.Contains("Eliminar") Then
                Dim pos As Integer = uic_GrillaDescuento.Rows.IndexOf(uic_GrillaDescuento.CurrentRow)
                uic_GrillaDescuento.Rows.RemoveAt(pos)
                CalculoTotal()
                CalculoDescuento()
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub uic_GrabaDTE_Click(sender As Object, e As EventArgs) Handles uic_GrabaDTE.Click
        Dim dto As New be.Facturas
        Dim util As New dac.Util
        Dim folio As Integer = util.GET_FolioDTE(33, "Demo")
        dto.get_tipoDTE = 33
        dto.get_folioDTE = folio
        MsgBox(folio)
    End Sub

    Private Sub uic_GrillaDescuento_Click(sender As Object, e As EventArgs) Handles uic_GrillaDescuento.Click

    End Sub
End Class