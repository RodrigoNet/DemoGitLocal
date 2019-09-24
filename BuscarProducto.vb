Public Class BuscarProducto

    Private Sub BuscarProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DTESISTEMDataSet.Producto' table. You can move, or remove it, as needed.
        Me.ProductoTableAdapter.Fill(Me.DTESISTEMDataSet.Producto)
        Me.uic_Descripcion.CheckState = CheckState.Checked
    End Sub
    Private Sub uic_Buscar_TextChanged(sender As Object, e As EventArgs) Handles uic_Buscar.TextChanged
        LlenoGrilla()
    End Sub

    Private Sub LlenoGrilla()
        Dim tipobusca As Integer = 0
        'Me.GdV_Clientes.Rows.Clear()

        If Me.uic_Descripcion.IsChecked = True Then
            tipobusca = 1
            Me.ProductoTableAdapter.Buscador_FillBy(Me.DTESISTEMDataSet.Producto, Me.uic_Buscar.Text.Trim, tipobusca)
        Else
            tipobusca = 2
            Try
                Me.ProductoTableAdapter.Buscador_FillBy(Me.DTESISTEMDataSet.Producto, Me.uic_Buscar.Text.Trim, tipobusca)
            Catch ex As Exception
            End Try

        End If
    End Sub

    
    Private Sub uic_Codigo_ToggleStateChanged(sender As Object, args As Telerik.WinControls.UI.StateChangedEventArgs) Handles uic_Codigo.ToggleStateChanged
        Me.ProductoTableAdapter.Limpiar_FillBy(Me.DTESISTEMDataSet.Producto)
    End Sub

    Private Sub GdV_Clientes_Click(sender As Object, e As EventArgs) Handles GdV_Productos.Click

    End Sub

    Private Sub GdV_Clientes_DoubleClick(sender As Object, e As EventArgs) Handles GdV_Productos.DoubleClick
        Dim pos As Integer = Me.GdV_Productos.Rows.IndexOf(Me.GdV_Productos.CurrentRow)
        Facturas.uic_CodigoProducto.Text = Me.GdV_Productos.Rows(pos).Cells(0).Value
        Facturas.uic_Producto.Text = Me.GdV_Productos.Rows(pos).Cells(1).Value
        Facturas.uic_UM.Text = Me.GdV_Productos.Rows(pos).Cells(3).Value
        Facturas.uic_Precio.Text = CInt(Me.GdV_Productos.Rows(pos).Cells(9).Value)
        Facturas.uic_Cantidad.Focus()
        Me.Close()
    End Sub
End Class