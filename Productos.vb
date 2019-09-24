Public Class Productos

    'Private Subuic_grabaEstaciones_Click(sender As Object, e As EventArgs)
    'Dim dts As New be.Productos
    'Dim func As New dac.Productos

    'dts.get_CodProducto = Me.uic_codigoProducto.Text
    'dts.get_Descripcion = Me.uic_Producto.Text
    'dts.get_InfoAdic = Me.uic_GlosaAdicional.Text
    'dts.get_UM = Me.uic_UM.Text
    'If Me.uic_exento.CheckState = CheckState.Checked Then
    '    dts.get_exento = True
    'Else
    '    dts.get_exento = False
    'End If
    'If Me.uic_CodigoBarra.Text <> "" Then
    '    dts.get_CodigoBarra = Me.uic_CodigoBarra.Text
    'Else
    '    dts.get_CodigoBarra = ""
    'End If
    'If Me.uic_CodigoProveedor.Text <> "" Then
    '    dts.get_CodigoProveedor = Me.uic_CodigoProveedor.Text
    'Else
    '    dts.get_CodigoProveedor = ""
    'End If
    'If Me.uic_CodigoExtra1.Text <> "" Then
    '    dts.get_CodigoExtra1 = Me.uic_CodigoExtra1.Text
    'Else
    '    dts.get_CodigoExtra1 = ""
    'End If
    'If Me.uic_CodigoExtra2.Text <> "" Then
    '    dts.get_CodigoExtra2 = Me.uic_CodigoExtra2.Text
    'Else
    '    dts.get_CodigoExtra2 = ""
    'End If

    'If Me.uic_CodImp1.Text <> "" Then
    '    dts.get_CodImpuestoAdic1 = Me.uic_CodImp1.Text
    'Else
    '    dts.get_CodImpuestoAdic1 = "0"
    'End If
    'If Me.uic_TasaImp1.Text <> "" Then
    '    dts.get_TasaImpAdic1 = Me.uic_TasaImp1.Text
    'Else
    '    dts.get_TasaImpAdic1 = "0"
    'End If
    'If Me.uic_CodImp1.Text <> "" Then
    '    dts.get_CodImpuestoAdic2 = Me.uic_CodImp1.Text
    'Else
    '    dts.get_CodImpuestoAdic2 = "0"
    'End If
    'If Me.uic_TasaImp2.Text <> "" Then
    '    dts.get_TasaImpAdic2 = Me.uic_TasaImp2.Text
    'Else
    '    dts.get_TasaImpAdic2 = "0"
    'End If


    'Dim resp As String = func.grabaProducto(dts)

    'If resp <> "OK" Then
    '    MsgBox(resp, vbInformation, "Aviso")
    'End If
    'End Sub

#Region "keypress"
    Private Sub uic_codigoProducto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_codigoProducto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Producto.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_GlosaAdicional_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_GlosaAdicional.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_Precio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_Precio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_CodigoBarra_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoBarra.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_UM_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_UM.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_CodigoProveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoProveedor.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_CodigoExtra1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoExtra1.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_CodigoExtra2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoExtra2.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

#End Region

#Region "UpperCase"
    Private Sub uic_codigoProducto_TextChanged(sender As Object, e As EventArgs) Handles uic_codigoProducto.TextChanged
        Me.uic_codigoProducto.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_Producto_TextChanged(sender As Object, e As EventArgs)
        Me.uic_Producto.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_GlosaAdicional_TextChanged(sender As Object, e As EventArgs)
        Me.uic_GlosaAdicional.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_UM_TextChanged(sender As Object, e As EventArgs)
        Me.uic_UM.CharacterCasing = CharacterCasing.Upper
    End Sub
#End Region

    Private Sub uic_grabaEstaciones_Click(sender As Object, e As EventArgs) Handles uic_grabaEstaciones.Click
        Dim dts As New be.Productos
        Dim func As New dac.Productos

        dts.get_CodProducto = Me.uic_codigoProducto.Text
        dts.get_Descripcion = Me.uic_Producto.Text
        dts.get_InfoAdic = Me.uic_GlosaAdicional.Text
        dts.get_UM = Me.uic_UM.Text
        If Me.uic_exento.CheckState = CheckState.Checked Then
            dts.get_exento = True
        Else
            dts.get_exento = False
        End If
        If Me.uic_CodigoBarra.Text <> "" Then
            dts.get_CodigoBarra = Me.uic_CodigoBarra.Text
        Else
            dts.get_CodigoBarra = ""
        End If
        If Me.uic_CodigoProveedor.Text <> "" Then
            dts.get_CodigoProveedor = Me.uic_CodigoProveedor.Text
        Else
            dts.get_CodigoProveedor = ""
        End If
        If Me.uic_CodigoExtra1.Text <> "" Then
            dts.get_CodigoExtra1 = Me.uic_CodigoExtra1.Text
        Else
            dts.get_CodigoExtra1 = ""
        End If
        If Me.uic_CodigoExtra2.Text <> "" Then
            dts.get_CodigoExtra2 = Me.uic_CodigoExtra2.Text
        Else
            dts.get_CodigoExtra2 = ""
        End If

        If Me.uic_CodImp1.Text <> "" Then
            dts.get_CodImpuestoAdic1 = Me.uic_CodImp1.Text
        Else
            dts.get_CodImpuestoAdic1 = "0"
        End If
        If Me.uic_TasaImp1.Text <> "" Then
            dts.get_TasaImpAdic1 = Me.uic_TasaImp1.Text
        Else
            dts.get_TasaImpAdic1 = "0"
        End If
        If Me.uic_CodImp1.Text <> "" Then
            dts.get_CodImpuestoAdic2 = Me.uic_CodImp1.Text
        Else
            dts.get_CodImpuestoAdic2 = "0"
        End If
        If Me.uic_TasaImp2.Text <> "" Then
            dts.get_TasaImpAdic2 = Me.uic_TasaImp2.Text
        Else
            dts.get_TasaImpAdic2 = "0"
        End If


        Dim resp As String = func.grabaProducto(dts)

        If resp <> "OK" Then
            MsgBox(resp, vbInformation, "Aviso")
        End If
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub
End Class