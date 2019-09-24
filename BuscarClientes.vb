Public Class BuscarClientes

    Private Sub BuscarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTESISTEMDataSet.Clientes' table. You can move, or remove it, as needed.
        Me.ClientesTableAdapter.Fill(Me.DTESISTEMDataSet.Clientes)
        Me.uic_RadioNombre.IsChecked = True

    End Sub

    Private Sub uic_Buscar_TextChanged(sender As Object, e As EventArgs) Handles uic_Buscar.TextChanged
        llenoGrilla()
    End Sub
    Private Sub LlenoGrilla()
        Dim tipobusca As Integer = 0
        If Me.uic_RadioNombre.IsChecked = True Then
            tipobusca = 1
            Me.ClientesTableAdapter.Buscador_FillBy(Me.DTESISTEMDataSet.Clientes, Me.uic_Buscar.Text.Trim, tipobusca)
        ElseIf Me.uic_RadioRut.IsChecked = True Then
            tipobusca = 2
            Me.ClientesTableAdapter.Buscador_FillBy(Me.DTESISTEMDataSet.Clientes, Me.uic_Buscar.Text.Trim, tipobusca)
        Else
            tipobusca = 3
            Me.ClientesTableAdapter.Buscador_FillBy(Me.DTESISTEMDataSet.Clientes, Me.uic_Buscar.Text.Trim, tipobusca)
        End If
        'BuscadorCliente
    End Sub


    Private Sub GdV_Clientes_Click(sender As Object, e As EventArgs) Handles GdV_Clientes.Click

    End Sub

    Private Sub GdV_Clientes_DoubleClick(sender As Object, e As EventArgs) Handles GdV_Clientes.DoubleClick
        Dim pos As Integer = Me.GdV_Clientes.Rows.IndexOf(Me.GdV_Clientes.CurrentRow)
        Facturas.uic_rut.Text = Me.GdV_Clientes.Rows(pos).Cells(0).Value
        Facturas.uic_RazonSocial.Text = Me.GdV_Clientes.Rows(pos).Cells(2).Value
        Me.Close()
    End Sub
End Class