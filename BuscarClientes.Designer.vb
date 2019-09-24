<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarClientes
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
        Me.components = New System.ComponentModel.Container()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn2 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn3 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn4 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn11 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_RadioCodigo = New Telerik.WinControls.UI.RadRadioButton()
        Me.uic_RadioRut = New Telerik.WinControls.UI.RadRadioButton()
        Me.uic_RadioNombre = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_Buscar = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.GdV_Clientes = New Telerik.WinControls.UI.RadGridView()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTESISTEMDataSet = New SistemaDte.DTESISTEMDataSet()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.ClientesTableAdapter = New SistemaDte.DTESISTEMDataSetTableAdapters.ClientesTableAdapter()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_RadioCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_RadioRut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_RadioNombre, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.uic_Buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.GdV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdV_Clientes.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_RadioCodigo)
        Me.RadGroupBox1.Controls.Add(Me.uic_RadioRut)
        Me.RadGroupBox1.Controls.Add(Me.uic_RadioNombre)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(6, 0)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(530, 66)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_RadioCodigo
        '
        Me.uic_RadioCodigo.Location = New System.Drawing.Point(332, 24)
        Me.uic_RadioCodigo.Name = "uic_RadioCodigo"
        Me.uic_RadioCodigo.Size = New System.Drawing.Size(94, 18)
        Me.uic_RadioCodigo.TabIndex = 2
        Me.uic_RadioCodigo.Text = "Codigo Cliente"
        Me.uic_RadioCodigo.ThemeName = "Office2010Black"
        '
        'uic_RadioRut
        '
        Me.uic_RadioRut.Location = New System.Drawing.Point(205, 24)
        Me.uic_RadioRut.Name = "uic_RadioRut"
        Me.uic_RadioRut.Size = New System.Drawing.Size(86, 18)
        Me.uic_RadioRut.TabIndex = 1
        Me.uic_RadioRut.Text = "R.U.T. Cliente"
        Me.uic_RadioRut.ThemeName = "Office2010Black"
        '
        'uic_RadioNombre
        '
        Me.uic_RadioNombre.Location = New System.Drawing.Point(65, 24)
        Me.uic_RadioNombre.Name = "uic_RadioNombre"
        Me.uic_RadioNombre.Size = New System.Drawing.Size(83, 18)
        Me.uic_RadioNombre.TabIndex = 0
        Me.uic_RadioNombre.Text = "Razon Social"
        Me.uic_RadioNombre.ThemeName = "Office2010Black"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.uic_Buscar)
        Me.RadGroupBox2.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(6, 68)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(530, 59)
        Me.RadGroupBox2.TabIndex = 1
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        '
        'uic_Buscar
        '
        Me.uic_Buscar.Location = New System.Drawing.Point(78, 19)
        Me.uic_Buscar.Name = "uic_Buscar"
        Me.uic_Buscar.Size = New System.Drawing.Size(153, 20)
        Me.uic_Buscar.TabIndex = 1
        '
        'RadLabel1
        '
        Me.RadLabel1.Location = New System.Drawing.Point(33, 20)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(39, 18)
        Me.RadLabel1.TabIndex = 0
        Me.RadLabel1.Text = "Buscar"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.GdV_Clientes)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(6, 128)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(530, 356)
        Me.RadGroupBox3.TabIndex = 2
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        '
        'GdV_Clientes
        '
        Me.GdV_Clientes.BackColor = System.Drawing.SystemColors.Control
        Me.GdV_Clientes.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdV_Clientes.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GdV_Clientes.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GdV_Clientes.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GdV_Clientes.Location = New System.Drawing.Point(6, 7)
        '
        '
        '
        Me.GdV_Clientes.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "RutCliente"
        GridViewTextBoxColumn1.HeaderText = "R.U.T."
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "RutCliente"
        GridViewTextBoxColumn1.Width = 70
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "CodInternoCliente"
        GridViewTextBoxColumn2.HeaderText = "Cod. Cliente"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "CodInternoCliente"
        GridViewTextBoxColumn2.Width = 60
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "RazonSocialCliente"
        GridViewTextBoxColumn3.HeaderText = "Razon Social"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "RazonSocialCliente"
        GridViewTextBoxColumn3.Width = 110
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "GiroCliente"
        GridViewTextBoxColumn4.HeaderText = "Giro Cliente"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "GiroCliente"
        GridViewTextBoxColumn4.Width = 110
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "DireccionCliente"
        GridViewTextBoxColumn5.HeaderText = "Direccion"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "DireccionCliente"
        GridViewTextBoxColumn5.Width = 100
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "ComunaCliente"
        GridViewTextBoxColumn6.HeaderText = "Comuna"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "ComunaCliente"
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "CiudadCliente"
        GridViewTextBoxColumn7.HeaderText = "CiudadCliente"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.IsVisible = False
        GridViewTextBoxColumn7.Name = "CiudadCliente"
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "EmailPDF"
        GridViewTextBoxColumn8.HeaderText = "EmailPDF"
        GridViewTextBoxColumn8.IsAutoGenerated = True
        GridViewTextBoxColumn8.IsVisible = False
        GridViewTextBoxColumn8.Name = "EmailPDF"
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.FieldName = "EmailXML"
        GridViewTextBoxColumn9.HeaderText = "EmailXML"
        GridViewTextBoxColumn9.IsAutoGenerated = True
        GridViewTextBoxColumn9.IsVisible = False
        GridViewTextBoxColumn9.Name = "EmailXML"
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "CodDescuento"
        GridViewTextBoxColumn10.HeaderText = "CodDescuento"
        GridViewTextBoxColumn10.IsAutoGenerated = True
        GridViewTextBoxColumn10.IsVisible = False
        GridViewTextBoxColumn10.Name = "CodDescuento"
        GridViewDecimalColumn1.DataType = GetType(Long)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "CreditoDisponible"
        GridViewDecimalColumn1.HeaderText = "CreditoDisponible"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "CreditoDisponible"
        GridViewTextBoxColumn11.EnableExpressionEditor = False
        GridViewTextBoxColumn11.FieldName = "telefono"
        GridViewTextBoxColumn11.HeaderText = "telefono"
        GridViewTextBoxColumn11.IsAutoGenerated = True
        GridViewTextBoxColumn11.IsVisible = False
        GridViewTextBoxColumn11.Name = "telefono"
        Me.GdV_Clientes.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewDecimalColumn1, GridViewTextBoxColumn11})
        Me.GdV_Clientes.MasterTemplate.DataSource = Me.ClientesBindingSource
        Me.GdV_Clientes.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GdV_Clientes.Name = "GdV_Clientes"
        Me.GdV_Clientes.ReadOnly = True
        Me.GdV_Clientes.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GdV_Clientes.Size = New System.Drawing.Size(519, 341)
        Me.GdV_Clientes.TabIndex = 1
        Me.GdV_Clientes.Text = "RadGridView1"
        Me.GdV_Clientes.ThemeName = "Office2010Black"
        '
        'ClientesBindingSource
        '
        Me.ClientesBindingSource.DataMember = "Clientes"
        Me.ClientesBindingSource.DataSource = Me.DTESISTEMDataSet
        '
        'DTESISTEMDataSet
        '
        Me.DTESISTEMDataSet.DataSetName = "DTESISTEMDataSet"
        Me.DTESISTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ClientesTableAdapter
        '
        Me.ClientesTableAdapter.ClearBeforeFill = True
        '
        'BuscarClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(548, 488)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "BuscarClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarClientes"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.uic_RadioCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_RadioRut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_RadioNombre, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.RadGroupBox2.PerformLayout()
        CType(Me.uic_Buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.GdV_Clientes.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_RadioCodigo As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_RadioRut As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_RadioNombre As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents GdV_Clientes As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents uic_Buscar As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents DTESISTEMDataSet As SistemaDte.DTESISTEMDataSet
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ClientesTableAdapter As SistemaDte.DTESISTEMDataSetTableAdapters.ClientesTableAdapter
End Class
