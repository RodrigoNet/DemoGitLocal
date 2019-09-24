Public Class Menu

    Private Sub ToolStripSplitButton1_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton1.ButtonClick
        Me.ToolStripSplitButton1.ShowDropDown()
    End Sub

    Private Sub ToolStripSplitButton3_ButtonClick(sender As Object, e As EventArgs) Handles ToolStripSplitButton3.ButtonClick
        Me.ToolStripSplitButton3.ShowDropDown()
    End Sub

    Private Sub ToolStripButton6_Click(sender As Object, e As EventArgs) Handles ToolStripButton6.Click
        End
    End Sub

    Private Sub FACTURAsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FACTURAsToolStripMenuItem.Click
        Facturas.Show()
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        Clientes.Show()
    End Sub

    Private Sub EstacionToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ConfiguracionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConfiguracionToolStripMenuItem.Click
        Usuarios.Show()
    End Sub

    Private Sub SucursalToolStripMenuItem_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ProductosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductosToolStripMenuItem.Click
        Productos.Show()
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProveedoresToolStripMenuItem.Click
        Proveedor.Show()
    End Sub

    Private Sub RolesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles RolesToolStripMenuItem1.Click
        Roles.Show()
    End Sub

    Private Sub SucursalToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SucursalToolStripMenuItem1.Click
        Sucursal.Show()
    End Sub

    Private Sub EstacionToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EstacionToolStripMenuItem1.Click
        Estaciones.Show()
    End Sub

    Private Sub FormaPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormaPagoToolStripMenuItem.Click
        F_Pago.Show()
    End Sub

    Private Sub ParametrosGeneralesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ParametrosGeneralesToolStripMenuItem1.Click
        Paramgral.Show()
    End Sub

    Private Sub ControlFolioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ControlFolioToolStripMenuItem.Click
        ControlFolios.ShowDialog()
    End Sub
End Class