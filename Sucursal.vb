Public Class Sucursal

    Private Sub uic_CodigoSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoSucursal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub uic_CodigoSucursal_TextChanged(sender As Object, e As EventArgs) Handles uic_CodigoSucursal.TextChanged
        Me.uic_CodigoSucursal.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_NombreSucursal_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_NombreSucursal.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub uic_NombreSucursal_TextChanged(sender As Object, e As EventArgs) Handles uic_NombreSucursal.TextChanged
        Me.uic_NombreSucursal.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_grabaSucursal_Click(sender As Object, e As EventArgs) Handles uic_grabaSucursal.Click

    End Sub

End Class