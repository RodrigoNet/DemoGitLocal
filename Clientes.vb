Public Class Clientes
    Dim rut As New BC.RUTman

    Private Sub Buscar_Cliente()
        Dim dts As New be.Clientes
        Dim func As New dac.Clientes

        dts = func.Buscar_Cliente(Me.uic_RUT.Text.Trim.ToUpper)

        Me.uic_CodCliente.Text = Trim(dts.get_CodCliente)
        Me.uic_RazonSocial.Text = Trim(dts.get_razonsocial)
        Me.uic_Giro.Text = Trim(dts.get_giro)
        Me.uic_Direccion.Text = Trim(dts.get_direccion)
        Me.uic_Comuna.Text = Trim(dts.get_comuna)
        Me.uic_Ciudad.Text = Trim(dts.get_ciudad)
        Me.uic_Fono.Text = Trim(dts.get_fono)
        Me.uic_EmailPDF.Text = Trim(dts.get_emailpdf)
        Me.uic_EmailXML.Text = Trim(dts.get_emailxml)

    End Sub

    Private Sub Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTESISTEMDataSet1.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.DTESISTEMDataSet1.Clientes)

    End Sub

    Private Sub limpiar()
        Me.uic_RUT.Text = ""
        Me.uic_CodCliente.Text = ""
        Me.uic_RazonSocial.Text = ""
        Me.uic_Giro.Text = ""
        Me.uic_Direccion.Text = ""
        Me.uic_Comuna.Text = ""
        Me.uic_Ciudad.Text = ""
        Me.uic_Fono.Text = ""
        Me.uic_EmailPDF.Text = ""
        Me.uic_EmailXML.Text = ""
        Me.uic_GrabaCliente.Enabled = True
    End Sub

    Private Function valida() As String
        Dim resp As String = ""

        If Me.uic_RUT.Text.Trim = "" Then
            resp += "Debe ingresar RUT" & vbCr
        End If
        If Me.uic_CodCliente.Text.Trim = "" Then
            resp += "Debe ingresar Codigo cliente" & vbCr
        End If
        If Me.uic_RazonSocial.Text.Trim = "" Then
            resp += "Debe ingresar Razon Social" & vbCr
        End If
        If Me.uic_Giro.Text.Trim = "" Then
            resp += "Debe ingresar Giro" & vbCr
        End If
        If Me.uic_Direccion.Text.Trim = "" Then
            resp += "Debe ingresar Direccion" & vbCr
        End If
        If Me.uic_Comuna.Text.Trim = "" Then
            resp += "Debe ingresar Comuna" & vbCr
        End If
        If Me.uic_Ciudad.Text.Trim = "" Then
            resp += "Debe ingresar Ciudad" & vbCr
        End If

        If resp = "" Then
            resp = "OK"
        End If

        Return resp
    End Function

#Region "keypress"
    Private Sub uic_RUT_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_RUT.KeyPress
        If Me.uic_RUT.Text = "" Then
            Exit Sub
        End If
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            If Not rut.check_es_valido(Me.uic_RUT.Text) Then
                MsgBox("Error, RUT no valido", MsgBoxStyle.Critical, "Error")
            End If

            Buscar_Cliente()
        End If
    End Sub
    Private Sub uic_RazonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_RazonSocial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Giro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Giro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_CodCliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodCliente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Direccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Comuna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Comuna.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Ciudad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Fono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Fono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_EmailPDF_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_EmailPDF.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_EmailXML_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_EmailXML.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region


#Region "UpperCase"
    Private Sub uic_RazonSocial_TextChanged(sender As Object, e As EventArgs) Handles uic_RazonSocial.TextChanged
        Me.uic_RazonSocial.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_RUT_TextChanged(sender As Object, e As EventArgs) Handles uic_RUT.TextChanged
        Me.uic_RUT.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_Giro_TextChanged(sender As Object, e As EventArgs) Handles uic_Giro.TextChanged
        Me.uic_Giro.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_CodCliente_TextChanged(sender As Object, e As EventArgs) Handles uic_CodCliente.TextChanged
        Me.uic_CodCliente.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_Direccion_TextChanged(sender As Object, e As EventArgs) Handles uic_Direccion.TextChanged
        Me.uic_Direccion.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_Comuna_TextChanged(sender As Object, e As EventArgs) Handles uic_Comuna.TextChanged
        Me.uic_Comuna.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_Ciudad_TextChanged(sender As Object, e As EventArgs) Handles uic_Ciudad.TextChanged
        Me.uic_Ciudad.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_Fono_TextChanged(sender As Object, e As EventArgs) Handles uic_Fono.TextChanged
        Me.uic_Fono.CharacterCasing = CharacterCasing.Upper
    End Sub
#End Region

    Private Sub uic_GrabaCliente_Click(sender As Object, e As EventArgs) Handles uic_GrabaCliente.Click
        Dim respuesta As String = valida()
        If respuesta <> "OK" Then
            MsgBox(respuesta)
            Exit Sub
        End If
        Dim dts As New be.Clientes
        Dim func As New dac.Clientes

        dts.get_rut = Me.uic_RUT.Text
        dts.get_CodCliente = Me.uic_CodCliente.Text
        dts.get_razonsocial = Me.uic_RazonSocial.Text
        dts.get_giro = Me.uic_Giro.Text
        dts.get_direccion = Me.uic_Direccion.Text
        dts.get_comuna = Me.uic_Comuna.Text
        dts.get_ciudad = Me.uic_Ciudad.Text
        dts.get_emailpdf = Me.uic_EmailPDF.Text
        dts.get_emailxml = Me.uic_EmailXML.Text
        dts.get_fono = Me.uic_Fono.Text

        Dim resp As String = func.grabaCliente(dts)

        If resp <> "OK" Then
            MsgBox(resp, vbInformation, "Aviso")
        End If

        limpiar()
        Me.ClientesTableAdapter.Fill(Me.DTESISTEMDataSet1.Clientes)

    End Sub

    Private Sub uic_Limpiar_Click(sender As Object, e As EventArgs) Handles uic_Limpiar.Click
        limpiar()
    End Sub

    Private Sub RadGridView1_Click(sender As Object, e As EventArgs) Handles RadGridView1.Click

    End Sub

    Private Sub RadGridView1_DoubleClick(sender As Object, e As EventArgs) Handles RadGridView1.DoubleClick
        Me.uic_GrabaCliente.Enabled = False
        Dim Linea As Integer
        If RadGridView1.Rows.Count > 0 Then
            Linea = RadGridView1.Rows.IndexOf(RadGridView1.CurrentRow)
            Me.uic_RUT.Text = Trim(RadGridView1.Rows(Linea).Cells(0).Value)
            Me.uic_CodCliente.Text = Trim(RadGridView1.Rows(Linea).Cells(1).Value)
            Me.uic_RazonSocial.Text = Trim(RadGridView1.Rows(Linea).Cells(2).Value)
            Me.uic_Giro.Text = Trim(RadGridView1.Rows(Linea).Cells(3).Value)
            Me.uic_Direccion.Text = Trim(RadGridView1.Rows(Linea).Cells(4).Value)
            Me.uic_Comuna.Text = Trim(RadGridView1.Rows(Linea).Cells(5).Value)
            Me.uic_Ciudad.Text = Trim(RadGridView1.Rows(Linea).Cells(6).Value)
            Me.uic_Fono.Text = Trim(RadGridView1.Rows(Linea).Cells(7).Value)
            Me.uic_EmailPDF.Text = Trim(RadGridView1.Rows(Linea).Cells(8).Value)
            Me.uic_EmailXML.Text = Trim(RadGridView1.Rows(Linea).Cells(9).Value)
        End If
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub

    Private Sub uic_ModificaCliente_Click(sender As Object, e As EventArgs) Handles uic_ModificaCliente.Click
        Dim respuesta As String = valida()
        If respuesta <> "OK" Then
            MsgBox(respuesta)
            Exit Sub
        End If
        Dim dts As New be.Clientes
        Dim func As New dac.Clientes

        dts.get_rut = Me.uic_RUT.Text
        dts.get_CodCliente = Me.uic_CodCliente.Text
        dts.get_razonsocial = Me.uic_RazonSocial.Text
        dts.get_giro = Me.uic_Giro.Text
        dts.get_direccion = Me.uic_Direccion.Text
        dts.get_comuna = Me.uic_Comuna.Text
        dts.get_ciudad = Me.uic_Ciudad.Text
        dts.get_emailpdf = Me.uic_EmailPDF.Text
        dts.get_emailxml = Me.uic_EmailXML.Text
        dts.get_fono = Me.uic_Fono.Text

        Dim resp As String = func.ModificarCliente(dts)

        If resp <> "OK" Then
            MsgBox(resp, vbInformation, "Aviso")
        End If

        limpiar()
        Me.ClientesTableAdapter.Fill(Me.DTESISTEMDataSet1.Clientes)

    End Sub
End Class

