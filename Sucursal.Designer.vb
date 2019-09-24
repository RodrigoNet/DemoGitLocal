<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sucursal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.uic_NroCopiasNC = New System.Windows.Forms.TextBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.uic_TipoNC = New System.Windows.Forms.ComboBox()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.uic_grabaSucursal = New System.Windows.Forms.Button()
        Me.uic_NroCopiasBA = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.uic_NroCopiasFA = New System.Windows.Forms.TextBox()
        Me.uic_TipoBoleta = New System.Windows.Forms.ComboBox()
        Me.uic_TipoFactura = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.uic_CodigoSucursal = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.uic_NombreSucursal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.uic_NroCopiasNC)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Controls.Add(Me.uic_TipoNC)
        Me.GroupBox1.Controls.Add(Me.Label36)
        Me.GroupBox1.Controls.Add(Me.uic_grabaSucursal)
        Me.GroupBox1.Controls.Add(Me.uic_NroCopiasBA)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.uic_NroCopiasFA)
        Me.GroupBox1.Controls.Add(Me.uic_TipoBoleta)
        Me.GroupBox1.Controls.Add(Me.uic_TipoFactura)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.uic_CodigoSucursal)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.uic_NombreSucursal)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, -2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(586, 497)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'uic_NroCopiasNC
        '
        Me.uic_NroCopiasNC.Location = New System.Drawing.Point(385, 139)
        Me.uic_NroCopiasNC.MaxLength = 2
        Me.uic_NroCopiasNC.Name = "uic_NroCopiasNC"
        Me.uic_NroCopiasNC.Size = New System.Drawing.Size(49, 20)
        Me.uic_NroCopiasNC.TabIndex = 37
        Me.uic_NroCopiasNC.Visible = False
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(288, 142)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(92, 15)
        Me.Label35.TabIndex = 39
        Me.Label35.Text = "Nro Copias NC"
        Me.Label35.Visible = False
        '
        'uic_TipoNC
        '
        Me.uic_TipoNC.FormattingEnabled = True
        Me.uic_TipoNC.Items.AddRange(New Object() {"NC Manual", "NC Electronica"})
        Me.uic_TipoNC.Location = New System.Drawing.Point(106, 139)
        Me.uic_TipoNC.Name = "uic_TipoNC"
        Me.uic_TipoNC.Size = New System.Drawing.Size(165, 21)
        Me.uic_TipoNC.TabIndex = 36
        Me.uic_TipoNC.Visible = False
        '
        'Label36
        '
        Me.Label36.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(18, 139)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(85, 19)
        Me.Label36.TabIndex = 38
        Me.Label36.Text = "Tipo NC"
        Me.Label36.Visible = False
        '
        'uic_grabaSucursal
        '
        Me.uic_grabaSucursal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_grabaSucursal.Image = Global.SistemaDte.My.Resources.Resources.disk_blue2
        Me.uic_grabaSucursal.Location = New System.Drawing.Point(440, 126)
        Me.uic_grabaSucursal.Name = "uic_grabaSucursal"
        Me.uic_grabaSucursal.Size = New System.Drawing.Size(37, 32)
        Me.uic_grabaSucursal.TabIndex = 16
        Me.uic_grabaSucursal.UseVisualStyleBackColor = True
        '
        'uic_NroCopiasBA
        '
        Me.uic_NroCopiasBA.Location = New System.Drawing.Point(385, 109)
        Me.uic_NroCopiasBA.MaxLength = 2
        Me.uic_NroCopiasBA.Name = "uic_NroCopiasBA"
        Me.uic_NroCopiasBA.Size = New System.Drawing.Size(49, 20)
        Me.uic_NroCopiasBA.TabIndex = 7
        Me.uic_NroCopiasBA.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(288, 112)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 15)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "Nro Copias BA"
        Me.Label9.Visible = False
        '
        'uic_NroCopiasFA
        '
        Me.uic_NroCopiasFA.Location = New System.Drawing.Point(385, 79)
        Me.uic_NroCopiasFA.MaxLength = 2
        Me.uic_NroCopiasFA.Name = "uic_NroCopiasFA"
        Me.uic_NroCopiasFA.Size = New System.Drawing.Size(49, 20)
        Me.uic_NroCopiasFA.TabIndex = 5
        Me.uic_NroCopiasFA.Visible = False
        '
        'uic_TipoBoleta
        '
        Me.uic_TipoBoleta.FormattingEnabled = True
        Me.uic_TipoBoleta.Items.AddRange(New Object() {"Boleta Manual", "Boleta Electronica"})
        Me.uic_TipoBoleta.Location = New System.Drawing.Point(106, 109)
        Me.uic_TipoBoleta.Name = "uic_TipoBoleta"
        Me.uic_TipoBoleta.Size = New System.Drawing.Size(165, 21)
        Me.uic_TipoBoleta.TabIndex = 6
        Me.uic_TipoBoleta.Visible = False
        '
        'uic_TipoFactura
        '
        Me.uic_TipoFactura.FormattingEnabled = True
        Me.uic_TipoFactura.Items.AddRange(New Object() {"Factura Manual", "Factura Electronica"})
        Me.uic_TipoFactura.Location = New System.Drawing.Point(106, 79)
        Me.uic_TipoFactura.Name = "uic_TipoFactura"
        Me.uic_TipoFactura.Size = New System.Drawing.Size(166, 21)
        Me.uic_TipoFactura.TabIndex = 4
        Me.uic_TipoFactura.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(288, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(90, 15)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "Nro Copias FA"
        Me.Label8.Visible = False
        '
        'Label7
        '
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(18, 109)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 20)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Tipo Boleta"
        Me.Label7.Visible = False
        '
        'Label6
        '
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 79)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tipo Factura"
        Me.Label6.Visible = False
        '
        'uic_CodigoSucursal
        '
        Me.uic_CodigoSucursal.Location = New System.Drawing.Point(106, 24)
        Me.uic_CodigoSucursal.MaxLength = 10
        Me.uic_CodigoSucursal.Name = "uic_CodigoSucursal"
        Me.uic_CodigoSucursal.Size = New System.Drawing.Size(165, 20)
        Me.uic_CodigoSucursal.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(18, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(85, 19)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Codigo  Suc."
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(18, 170)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(545, 321)
        Me.DataGridView1.TabIndex = 35
        '
        'uic_NombreSucursal
        '
        Me.uic_NombreSucursal.Location = New System.Drawing.Point(106, 50)
        Me.uic_NombreSucursal.MaxLength = 50
        Me.uic_NombreSucursal.Name = "uic_NombreSucursal"
        Me.uic_NombreSucursal.Size = New System.Drawing.Size(328, 20)
        Me.uic_NombreSucursal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(18, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 18)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre Suc."
        '
        'Sucursal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 513)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Sucursal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sucursal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents uic_NroCopiasNC As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents uic_TipoNC As System.Windows.Forms.ComboBox
    Friend WithEvents Label36 As System.Windows.Forms.Label
    Friend WithEvents uic_grabaSucursal As System.Windows.Forms.Button
    Friend WithEvents uic_NroCopiasBA As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents uic_NroCopiasFA As System.Windows.Forms.TextBox
    Friend WithEvents uic_TipoBoleta As System.Windows.Forms.ComboBox
    Friend WithEvents uic_TipoFactura As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents uic_CodigoSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents uic_NombreSucursal As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
