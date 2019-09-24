Public Class F_Pago

    Private Sub F_Pago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTESISTEMDataSet.FormaDePago' table. You can move, or remove it, as needed.
        Me.FormaDePagoTableAdapter.Fill(Me.DTESISTEMDataSet.FormaDePago)

    End Sub

    Private Sub uic_grabaEstaciones_Click(sender As Object, e As EventArgs) Handles uic_grabaEstaciones.Click
        If Me.uic_F_Pago.Text = "" Then
            Exit Sub
        End If

        Dim dts As New be.F_Pago
        Dim func As New dac.F_Pago

        dts.get_F_Pago = Me.uic_F_Pago.Text.Trim
        Dim resp As String = func.graba_F_Pago(dts)

        If resp <> "OK" Then
            MsgBox(resp, vbInformation, "Aviso")
        End If

        Me.FormaDePagoTableAdapter.Fill(Me.DTESISTEMDataSet.FormaDePago)
        Me.uic_F_Pago.Text = ""
    End Sub

    Private Sub uic_F_Pago_TextChanged(sender As Object, e As EventArgs) Handles uic_F_Pago.TextChanged
        Me.uic_F_Pago.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub uic_Salir_Click(sender As Object, e As EventArgs) Handles uic_Salir.Click
        Me.Close()
    End Sub
End Class