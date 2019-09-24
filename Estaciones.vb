Public Class Estaciones

#Region "KeyPress"
    Private Sub uic_CodigoEstacion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_CodigoEstacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "UpperCase"
    Private Sub uic_CodigoEstacion_TextChanged(sender As Object, e As EventArgs) Handles uic_CodigoEstacion.TextChanged
        Me.uic_CodigoEstacion.CharacterCasing = CharacterCasing.Upper
    End Sub
#End Region

    Private Sub uic_EmiteFA_CheckStateChanged(sender As Object, e As EventArgs) Handles uic_EmiteFA.CheckStateChanged
        If uic_EmiteFA.CheckState = CheckState.Checked Then
            Me.uic_TipoFactura.Enabled = True
        Else
            Me.uic_TipoFactura.Enabled = False
        End If
    End Sub

    Private Sub uic_EmiteBA_CheckStateChanged(sender As Object, e As EventArgs) Handles uic_EmiteBA.CheckStateChanged
        If Me.uic_EmiteBA.CheckState = CheckState.Checked Then
            Me.uic_TipoBoleta.Enabled = True
        Else
            Me.uic_TipoBoleta.Enabled = False
        End If
    End Sub

    Private Sub uic_EmiteNC_CheckStateChanged(sender As Object, e As EventArgs) Handles uic_EmiteNC.CheckStateChanged
        If Me.uic_EmiteNC.CheckState = CheckState.Checked Then
            Me.uic_TipoNC.Enabled = True
        Else
            Me.uic_TipoNC.Enabled = False
        End If
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub
End Class