<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarProducto
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
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewTextBoxColumn5 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn6 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn2 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewDecimalColumn3 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_Buscar = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Descripcion = New Telerik.WinControls.UI.RadRadioButton()
        Me.uic_Codigo = New Telerik.WinControls.UI.RadRadioButton()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.GdV_Productos = New Telerik.WinControls.UI.RadGridView()
        Me.ProductoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTESISTEMDataSet = New SistemaDte.DTESISTEMDataSet()
        Me.ProductoTableAdapter = New SistemaDte.DTESISTEMDataSetTableAdapters.ProductoTableAdapter()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_Buscar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Descripcion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.GdV_Productos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GdV_Productos.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_Buscar)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.uic_Descripcion)
        Me.RadGroupBox1.Controls.Add(Me.uic_Codigo)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(9, 8)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(628, 98)
        Me.RadGroupBox1.TabIndex = 1
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_Buscar
        '
        Me.uic_Buscar.Location = New System.Drawing.Point(78, 53)
        Me.uic_Buscar.Name = "uic_Buscar"
        Me.uic_Buscar.Size = New System.Drawing.Size(153, 20)
        Me.uic_Buscar.TabIndex = 3
        '
        'RadLabel2
        '
        Me.RadLabel2.Location = New System.Drawing.Point(33, 54)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(39, 18)
        Me.RadLabel2.TabIndex = 2
        Me.RadLabel2.Text = "Buscar"
        '
        'uic_Descripcion
        '
        Me.uic_Descripcion.Location = New System.Drawing.Point(33, 21)
        Me.uic_Descripcion.Name = "uic_Descripcion"
        Me.uic_Descripcion.Size = New System.Drawing.Size(78, 18)
        Me.uic_Descripcion.TabIndex = 1
        Me.uic_Descripcion.Text = "Descripcion"
        Me.uic_Descripcion.ThemeName = "Office2010Black"
        '
        'uic_Codigo
        '
        Me.uic_Codigo.Location = New System.Drawing.Point(143, 21)
        Me.uic_Codigo.Name = "uic_Codigo"
        Me.uic_Codigo.Size = New System.Drawing.Size(57, 18)
        Me.uic_Codigo.TabIndex = 0
        Me.uic_Codigo.Text = "Codigo"
        Me.uic_Codigo.ThemeName = "Office2010Black"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.GdV_Productos)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(9, 115)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(628, 356)
        Me.RadGroupBox3.TabIndex = 3
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        '
        'GdV_Productos
        '
        Me.GdV_Productos.BackColor = System.Drawing.SystemColors.Control
        Me.GdV_Productos.Cursor = System.Windows.Forms.Cursors.Default
        Me.GdV_Productos.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.GdV_Productos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.GdV_Productos.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.GdV_Productos.Location = New System.Drawing.Point(6, 7)
        '
        '
        '
        Me.GdV_Productos.MasterTemplate.AllowAddNewRow = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "CodProducto"
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "CodProducto"
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "Descripcion"
        GridViewTextBoxColumn2.HeaderText = "Descripcion"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "Descripcion"
        GridViewTextBoxColumn2.Width = 90
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.FieldName = "InfoAdic"
        GridViewTextBoxColumn3.HeaderText = "Descripcion 2"
        GridViewTextBoxColumn3.IsAutoGenerated = True
        GridViewTextBoxColumn3.Name = "InfoAdic"
        GridViewTextBoxColumn3.Width = 78
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "UM"
        GridViewTextBoxColumn4.HeaderText = "UM"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "UM"
        GridViewCheckBoxColumn1.EnableExpressionEditor = False
        GridViewCheckBoxColumn1.FieldName = "Exento"
        GridViewCheckBoxColumn1.HeaderText = "Exento"
        GridViewCheckBoxColumn1.IsAutoGenerated = True
        GridViewCheckBoxColumn1.MinWidth = 20
        GridViewCheckBoxColumn1.Name = "Exento"
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "CodImpuestoAdic1"
        GridViewTextBoxColumn5.HeaderText = "Cod. Imp. Adic1"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "CodImpuestoAdic1"
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "CodImpuestoAdic2"
        GridViewTextBoxColumn6.HeaderText = "Cod. Imp. Adic2"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "CodImpuestoAdic2"
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "TasaImpAdic1"
        GridViewDecimalColumn1.HeaderText = "Tasa Imp Adic1"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.Name = "TasaImpAdic1"
        GridViewDecimalColumn2.EnableExpressionEditor = False
        GridViewDecimalColumn2.FieldName = "TasaImpAdic2"
        GridViewDecimalColumn2.HeaderText = "Tasa Imp Adic2"
        GridViewDecimalColumn2.IsAutoGenerated = True
        GridViewDecimalColumn2.Name = "TasaImpAdic2"
        GridViewDecimalColumn3.EnableExpressionEditor = False
        GridViewDecimalColumn3.FieldName = "Precio"
        GridViewDecimalColumn3.HeaderText = "Precio"
        GridViewDecimalColumn3.IsAutoGenerated = True
        GridViewDecimalColumn3.Name = "Precio"
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "CodBarra"
        GridViewTextBoxColumn7.HeaderText = "CodBarra"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.Name = "CodBarra"
        Me.GdV_Productos.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewCheckBoxColumn1, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewDecimalColumn1, GridViewDecimalColumn2, GridViewDecimalColumn3, GridViewTextBoxColumn7})
        Me.GdV_Productos.MasterTemplate.DataSource = Me.ProductoBindingSource
        Me.GdV_Productos.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.GdV_Productos.Name = "GdV_Productos"
        Me.GdV_Productos.ReadOnly = True
        Me.GdV_Productos.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.GdV_Productos.Size = New System.Drawing.Size(611, 341)
        Me.GdV_Productos.TabIndex = 1
        Me.GdV_Productos.Text = "RadGridView1"
        Me.GdV_Productos.ThemeName = "Office2010Black"
        '
        'ProductoBindingSource
        '
        Me.ProductoBindingSource.DataMember = "Producto"
        Me.ProductoBindingSource.DataSource = Me.DTESISTEMDataSet
        '
        'DTESISTEMDataSet
        '
        Me.DTESISTEMDataSet.DataSetName = "DTESISTEMDataSet"
        Me.DTESISTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductoTableAdapter
        '
        Me.ProductoTableAdapter.ClearBeforeFill = True
        '
        'BuscarProducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(647, 488)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.Name = "BuscarProducto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BuscarProducto"
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.uic_Buscar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Descripcion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        CType(Me.GdV_Productos.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GdV_Productos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_Descripcion As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_Codigo As Telerik.WinControls.UI.RadRadioButton
    Friend WithEvents uic_Buscar As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents GdV_Productos As Telerik.WinControls.UI.RadGridView
    Friend WithEvents DTESISTEMDataSet As SistemaDte.DTESISTEMDataSet
    Friend WithEvents ProductoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents ProductoTableAdapter As SistemaDte.DTESISTEMDataSetTableAdapters.ProductoTableAdapter
End Class
