<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturas
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
        Dim GridViewCommandColumn1 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim SortDescriptor1 As Telerik.WinControls.Data.SortDescriptor = New Telerik.WinControls.Data.SortDescriptor()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Dim GridViewTextBoxColumn7 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn8 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn9 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewTextBoxColumn10 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim GridViewCheckBoxColumn1 As Telerik.WinControls.UI.GridViewCheckBoxColumn = New Telerik.WinControls.UI.GridViewCheckBoxColumn()
        Dim GridViewCommandColumn2 As Telerik.WinControls.UI.GridViewCommandColumn = New Telerik.WinControls.UI.GridViewCommandColumn()
        Dim TableViewDefinition2 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.FormaDePagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTESISTEMDataSet = New SistemaDte.DTESISTEMDataSet()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.uic_buscarCliente = New System.Windows.Forms.Button()
        Me.uic_BuscarProducto = New System.Windows.Forms.Button()
        Me.uic_AgregarDetalle = New System.Windows.Forms.Button()
        Me.uic_AgregaDescuento = New System.Windows.Forms.Button()
        Me.uic_Salir = New System.Windows.Forms.Button()
        Me.uic_Limpiar = New System.Windows.Forms.Button()
        Me.uic_GrabaDTE = New System.Windows.Forms.Button()
        Me.FormaDePagoTableAdapter = New SistemaDte.DTESISTEMDataSetTableAdapters.FormaDePagoTableAdapter()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_Formapago = New System.Windows.Forms.ComboBox()
        Me.uic_Vendedor = New Telerik.WinControls.UI.RadDropDownList()
        Me.uic_observaciones = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel4 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel3 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel2 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_FechaEmision = New Telerik.WinControls.UI.RadDateTimePicker()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_rut = New Telerik.WinControls.UI.RadTextBox()
        Me.uic_RazonSocial = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel6 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.uic_UM = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel10 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_GridDetalle = New Telerik.WinControls.UI.RadGridView()
        Me.uic_Precio = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel9 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Cantidad = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel8 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Producto = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel7 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_CodigoProducto = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel5 = New Telerik.WinControls.UI.RadLabel()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RadLabel16 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Recargo = New Telerik.WinControls.UI.RadCheckBox()
        Me.uic_Exento = New Telerik.WinControls.UI.RadLabel()
        Me.Chk_Exento = New Telerik.WinControls.UI.RadCheckBox()
        Me.RadLabel14 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Porciento = New Telerik.WinControls.UI.RadCheckBox()
        Me.uic_GrillaDescuento = New Telerik.WinControls.UI.RadGridView()
        Me.uic_RazonDescuento = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel17 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_ValorDescuento = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel18 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox3 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_TotalRecargo = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel20 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_TotalDescuento = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel19 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel15 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_montoExento = New Telerik.WinControls.UI.RadTextBox()
        Me.uic_IVA = New Telerik.WinControls.UI.RadTextBox()
        Me.uic_Total_Doc = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel11 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel12 = New Telerik.WinControls.UI.RadLabel()
        Me.RadLabel13 = New Telerik.WinControls.UI.RadLabel()
        Me.uic_Neto = New Telerik.WinControls.UI.RadTextBox()
        CType(Me.FormaDePagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_Vendedor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_observaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_FechaEmision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_rut, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_RazonSocial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.uic_UM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_GridDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_GridDetalle.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Precio, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Cantidad, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Producto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_CodigoProducto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Recargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Exento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chk_Exento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Porciento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_GrillaDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_GrillaDescuento.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_RazonDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_ValorDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox3.SuspendLayout()
        CType(Me.uic_TotalRecargo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_TotalDescuento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_montoExento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_IVA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Total_Doc, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.uic_Neto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FormaDePagoBindingSource
        '
        Me.FormaDePagoBindingSource.DataMember = "FormaDePago"
        Me.FormaDePagoBindingSource.DataSource = Me.DTESISTEMDataSet
        '
        'DTESISTEMDataSet
        '
        Me.DTESISTEMDataSet.DataSetName = "DTESISTEMDataSet"
        Me.DTESISTEMDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'uic_buscarCliente
        '
        Me.uic_buscarCliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_buscarCliente.Image = Global.SistemaDte.My.Resources.Resources.find2
        Me.uic_buscarCliente.Location = New System.Drawing.Point(417, 25)
        Me.uic_buscarCliente.Name = "uic_buscarCliente"
        Me.uic_buscarCliente.Size = New System.Drawing.Size(31, 27)
        Me.uic_buscarCliente.TabIndex = 3
        Me.uic_buscarCliente.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.uic_buscarCliente, "Buscar Cliente")
        Me.uic_buscarCliente.UseVisualStyleBackColor = True
        '
        'uic_BuscarProducto
        '
        Me.uic_BuscarProducto.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_BuscarProducto.Image = Global.SistemaDte.My.Resources.Resources.find2
        Me.uic_BuscarProducto.Location = New System.Drawing.Point(113, 24)
        Me.uic_BuscarProducto.Name = "uic_BuscarProducto"
        Me.uic_BuscarProducto.Size = New System.Drawing.Size(32, 29)
        Me.uic_BuscarProducto.TabIndex = 22
        Me.uic_BuscarProducto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.uic_BuscarProducto, "Buscar Producto")
        Me.uic_BuscarProducto.UseVisualStyleBackColor = True
        '
        'uic_AgregarDetalle
        '
        Me.uic_AgregarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_AgregarDetalle.Image = Global.SistemaDte.My.Resources.Resources.add2_
        Me.uic_AgregarDetalle.Location = New System.Drawing.Point(658, 19)
        Me.uic_AgregarDetalle.Name = "uic_AgregarDetalle"
        Me.uic_AgregarDetalle.Size = New System.Drawing.Size(32, 31)
        Me.uic_AgregarDetalle.TabIndex = 23
        Me.uic_AgregarDetalle.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.uic_AgregarDetalle, "Agregar Detalle")
        Me.uic_AgregarDetalle.UseVisualStyleBackColor = True
        '
        'uic_AgregaDescuento
        '
        Me.uic_AgregaDescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_AgregaDescuento.Image = Global.SistemaDte.My.Resources.Resources.add2_
        Me.uic_AgregaDescuento.Location = New System.Drawing.Point(616, 19)
        Me.uic_AgregaDescuento.Name = "uic_AgregaDescuento"
        Me.uic_AgregaDescuento.Size = New System.Drawing.Size(32, 31)
        Me.uic_AgregaDescuento.TabIndex = 36
        Me.uic_AgregaDescuento.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.ToolTip1.SetToolTip(Me.uic_AgregaDescuento, "Agregar Detalle")
        Me.uic_AgregaDescuento.UseVisualStyleBackColor = True
        '
        'uic_Salir
        '
        Me.uic_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_Salir.Image = Global.SistemaDte.My.Resources.Resources.exit2
        Me.uic_Salir.Location = New System.Drawing.Point(664, 85)
        Me.uic_Salir.Name = "uic_Salir"
        Me.uic_Salir.Size = New System.Drawing.Size(36, 36)
        Me.uic_Salir.TabIndex = 23
        Me.ToolTip1.SetToolTip(Me.uic_Salir, "Salir")
        Me.uic_Salir.UseVisualStyleBackColor = True
        '
        'uic_Limpiar
        '
        Me.uic_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_Limpiar.Image = Global.SistemaDte.My.Resources.Resources.refresh
        Me.uic_Limpiar.Location = New System.Drawing.Point(623, 85)
        Me.uic_Limpiar.Name = "uic_Limpiar"
        Me.uic_Limpiar.Size = New System.Drawing.Size(36, 36)
        Me.uic_Limpiar.TabIndex = 22
        Me.ToolTip1.SetToolTip(Me.uic_Limpiar, "Limpia pantalla")
        Me.uic_Limpiar.UseVisualStyleBackColor = True
        '
        'uic_GrabaDTE
        '
        Me.uic_GrabaDTE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_GrabaDTE.Image = Global.SistemaDte.My.Resources.Resources.disk_blue2
        Me.uic_GrabaDTE.Location = New System.Drawing.Point(585, 85)
        Me.uic_GrabaDTE.Name = "uic_GrabaDTE"
        Me.uic_GrabaDTE.Size = New System.Drawing.Size(36, 36)
        Me.uic_GrabaDTE.TabIndex = 21
        Me.ToolTip1.SetToolTip(Me.uic_GrabaDTE, "Graba Cliente")
        Me.uic_GrabaDTE.UseVisualStyleBackColor = True
        '
        'FormaDePagoTableAdapter
        '
        Me.FormaDePagoTableAdapter.ClearBeforeFill = True
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_Salir)
        Me.RadGroupBox1.Controls.Add(Me.uic_Limpiar)
        Me.RadGroupBox1.Controls.Add(Me.uic_GrabaDTE)
        Me.RadGroupBox1.Controls.Add(Me.uic_Formapago)
        Me.RadGroupBox1.Controls.Add(Me.uic_Vendedor)
        Me.RadGroupBox1.Controls.Add(Me.uic_observaciones)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel4)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel3)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel2)
        Me.RadGroupBox1.Controls.Add(Me.uic_FechaEmision)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.Controls.Add(Me.uic_rut)
        Me.RadGroupBox1.Controls.Add(Me.uic_RazonSocial)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel6)
        Me.RadGroupBox1.Controls.Add(Me.uic_buscarCliente)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(4, 7)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(719, 143)
        Me.RadGroupBox1.TabIndex = 0
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_Formapago
        '
        Me.uic_Formapago.DataSource = Me.FormaDePagoBindingSource
        Me.uic_Formapago.DisplayMember = "F_Pago"
        Me.uic_Formapago.FormattingEnabled = True
        Me.uic_Formapago.Location = New System.Drawing.Point(119, 61)
        Me.uic_Formapago.Name = "uic_Formapago"
        Me.uic_Formapago.Size = New System.Drawing.Size(121, 21)
        Me.uic_Formapago.TabIndex = 4
        Me.uic_Formapago.ValueMember = "id"
        '
        'uic_Vendedor
        '
        Me.uic_Vendedor.DropDownStyle = Telerik.WinControls.RadDropDownStyle.DropDownList
        Me.uic_Vendedor.Location = New System.Drawing.Point(354, 61)
        Me.uic_Vendedor.Name = "uic_Vendedor"
        Me.uic_Vendedor.Size = New System.Drawing.Size(176, 20)
        Me.uic_Vendedor.TabIndex = 5
        Me.uic_Vendedor.ThemeName = "Office2010Black"
        '
        'uic_observaciones
        '
        Me.uic_observaciones.Location = New System.Drawing.Point(121, 95)
        Me.uic_observaciones.MaxLength = 10
        Me.uic_observaciones.Name = "uic_observaciones"
        Me.uic_observaciones.Size = New System.Drawing.Size(409, 20)
        Me.uic_observaciones.TabIndex = 6
        Me.uic_observaciones.ThemeName = "Office2010Black"
        '
        'RadLabel4
        '
        Me.RadLabel4.AutoSize = False
        Me.RadLabel4.BorderVisible = True
        Me.RadLabel4.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel4.Location = New System.Drawing.Point(248, 62)
        Me.RadLabel4.Name = "RadLabel4"
        Me.RadLabel4.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel4.TabIndex = 14
        Me.RadLabel4.Text = "Vendedor"
        Me.RadLabel4.ThemeName = "office2010blacktheme1"
        '
        'RadLabel3
        '
        Me.RadLabel3.AutoSize = False
        Me.RadLabel3.BorderVisible = True
        Me.RadLabel3.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel3.Location = New System.Drawing.Point(16, 95)
        Me.RadLabel3.Name = "RadLabel3"
        Me.RadLabel3.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel3.TabIndex = 13
        Me.RadLabel3.Text = "Observaciones"
        Me.RadLabel3.ThemeName = "office2010blacktheme1"
        '
        'RadLabel2
        '
        Me.RadLabel2.AutoSize = False
        Me.RadLabel2.BorderVisible = True
        Me.RadLabel2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel2.Location = New System.Drawing.Point(16, 62)
        Me.RadLabel2.Name = "RadLabel2"
        Me.RadLabel2.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel2.TabIndex = 12
        Me.RadLabel2.Text = "Forma pago"
        Me.RadLabel2.ThemeName = "office2010blacktheme1"
        '
        'uic_FechaEmision
        '
        Me.uic_FechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.uic_FechaEmision.Location = New System.Drawing.Point(121, 28)
        Me.uic_FechaEmision.Name = "uic_FechaEmision"
        Me.uic_FechaEmision.Size = New System.Drawing.Size(105, 20)
        Me.uic_FechaEmision.TabIndex = 1
        Me.uic_FechaEmision.TabStop = False
        Me.uic_FechaEmision.ThemeName = "Office2010Black"
        Me.uic_FechaEmision.Value = New Date(CType(0, Long))
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.RadLabel1.BorderVisible = True
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(16, 29)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel1.TabIndex = 10
        Me.RadLabel1.Text = "Fecha Emision"
        Me.RadLabel1.ThemeName = "office2010blacktheme1"
        '
        'uic_rut
        '
        Me.uic_rut.Location = New System.Drawing.Point(310, 28)
        Me.uic_rut.MaxLength = 10
        Me.uic_rut.Name = "uic_rut"
        Me.uic_rut.Size = New System.Drawing.Size(100, 20)
        Me.uic_rut.TabIndex = 2
        Me.uic_rut.ThemeName = "Office2010Black"
        '
        'uic_RazonSocial
        '
        Me.uic_RazonSocial.Location = New System.Drawing.Point(451, 28)
        Me.uic_RazonSocial.MaxLength = 10
        Me.uic_RazonSocial.Name = "uic_RazonSocial"
        Me.uic_RazonSocial.Size = New System.Drawing.Size(249, 20)
        Me.uic_RazonSocial.TabIndex = 8
        Me.uic_RazonSocial.ThemeName = "Office2010Black"
        '
        'RadLabel6
        '
        Me.RadLabel6.AutoSize = False
        Me.RadLabel6.BorderVisible = True
        Me.RadLabel6.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel6.Location = New System.Drawing.Point(243, 28)
        Me.RadLabel6.Name = "RadLabel6"
        Me.RadLabel6.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel6.TabIndex = 7
        Me.RadLabel6.Text = "R.U.T."
        Me.RadLabel6.ThemeName = "office2010blacktheme1"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.TabControl1)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(4, 156)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(719, 392)
        Me.RadGroupBox2.TabIndex = 2
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(9, 4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(703, 385)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.uic_UM)
        Me.TabPage1.Controls.Add(Me.RadLabel10)
        Me.TabPage1.Controls.Add(Me.uic_GridDetalle)
        Me.TabPage1.Controls.Add(Me.uic_AgregarDetalle)
        Me.TabPage1.Controls.Add(Me.uic_BuscarProducto)
        Me.TabPage1.Controls.Add(Me.uic_Precio)
        Me.TabPage1.Controls.Add(Me.RadLabel9)
        Me.TabPage1.Controls.Add(Me.uic_Cantidad)
        Me.TabPage1.Controls.Add(Me.RadLabel8)
        Me.TabPage1.Controls.Add(Me.uic_Producto)
        Me.TabPage1.Controls.Add(Me.RadLabel7)
        Me.TabPage1.Controls.Add(Me.uic_CodigoProducto)
        Me.TabPage1.Controls.Add(Me.RadLabel5)
        Me.TabPage1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(695, 359)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Detalle"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'uic_UM
        '
        Me.uic_UM.AcceptsTab = True
        Me.uic_UM.HideSelection = False
        Me.uic_UM.Location = New System.Drawing.Point(459, 30)
        Me.uic_UM.MaxLength = 4
        Me.uic_UM.Name = "uic_UM"
        Me.uic_UM.Size = New System.Drawing.Size(44, 20)
        Me.uic_UM.TabIndex = 25
        Me.uic_UM.ThemeName = "Office2010Black"
        Me.uic_UM.WordWrap = False
        '
        'RadLabel10
        '
        Me.RadLabel10.AutoSize = False
        Me.RadLabel10.BorderVisible = True
        Me.RadLabel10.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel10.Location = New System.Drawing.Point(459, 6)
        Me.RadLabel10.Name = "RadLabel10"
        Me.RadLabel10.Size = New System.Drawing.Size(44, 18)
        Me.RadLabel10.TabIndex = 26
        Me.RadLabel10.Text = "U.M"
        Me.RadLabel10.ThemeName = "office2010blacktheme1"
        '
        'uic_GridDetalle
        '
        Me.uic_GridDetalle.BackColor = System.Drawing.SystemColors.Control
        Me.uic_GridDetalle.Cursor = System.Windows.Forms.Cursors.Default
        Me.uic_GridDetalle.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.uic_GridDetalle.ForeColor = System.Drawing.SystemColors.ControlText
        Me.uic_GridDetalle.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.uic_GridDetalle.Location = New System.Drawing.Point(8, 60)
        '
        '
        '
        Me.uic_GridDetalle.MasterTemplate.AllowAddNewRow = False
        Me.uic_GridDetalle.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "RutCliente"
        GridViewTextBoxColumn1.HeaderText = "Codigo"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "CodigoProducto"
        GridViewTextBoxColumn1.Width = 90
        GridViewTextBoxColumn2.EnableExpressionEditor = False
        GridViewTextBoxColumn2.FieldName = "CodInternoCliente"
        GridViewTextBoxColumn2.HeaderText = "Producto"
        GridViewTextBoxColumn2.IsAutoGenerated = True
        GridViewTextBoxColumn2.Name = "DescripcionProductor"
        GridViewTextBoxColumn2.SortOrder = Telerik.WinControls.UI.RadSortOrder.Ascending
        GridViewTextBoxColumn2.Width = 210
        GridViewTextBoxColumn3.EnableExpressionEditor = False
        GridViewTextBoxColumn3.HeaderText = "UM"
        GridViewTextBoxColumn3.Name = "UM"
        GridViewTextBoxColumn4.EnableExpressionEditor = False
        GridViewTextBoxColumn4.FieldName = "RazonSocialCliente"
        GridViewTextBoxColumn4.HeaderText = "Cantidad"
        GridViewTextBoxColumn4.IsAutoGenerated = True
        GridViewTextBoxColumn4.Name = "Cantidad"
        GridViewTextBoxColumn4.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn4.Width = 80
        GridViewTextBoxColumn5.EnableExpressionEditor = False
        GridViewTextBoxColumn5.FieldName = "GiroCliente"
        GridViewTextBoxColumn5.HeaderText = "Precio"
        GridViewTextBoxColumn5.IsAutoGenerated = True
        GridViewTextBoxColumn5.Name = "Precio"
        GridViewTextBoxColumn5.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn5.Width = 80
        GridViewTextBoxColumn6.EnableExpressionEditor = False
        GridViewTextBoxColumn6.FieldName = "DireccionCliente"
        GridViewTextBoxColumn6.HeaderText = "Total"
        GridViewTextBoxColumn6.IsAutoGenerated = True
        GridViewTextBoxColumn6.Name = "Total"
        GridViewTextBoxColumn6.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn6.Width = 80
        GridViewCommandColumn1.EnableExpressionEditor = False
        GridViewCommandColumn1.HeaderText = "Eliminar"
        GridViewCommandColumn1.Name = "Eliminar"
        GridViewCommandColumn1.Width = 75
        Me.uic_GridDetalle.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn1, GridViewTextBoxColumn2, GridViewTextBoxColumn3, GridViewTextBoxColumn4, GridViewTextBoxColumn5, GridViewTextBoxColumn6, GridViewCommandColumn1})
        SortDescriptor1.PropertyName = "DescripcionProductor"
        Me.uic_GridDetalle.MasterTemplate.SortDescriptors.AddRange(New Telerik.WinControls.Data.SortDescriptor() {SortDescriptor1})
        Me.uic_GridDetalle.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.uic_GridDetalle.Name = "uic_GridDetalle"
        Me.uic_GridDetalle.ReadOnly = True
        Me.uic_GridDetalle.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uic_GridDetalle.Size = New System.Drawing.Size(681, 292)
        Me.uic_GridDetalle.TabIndex = 24
        Me.uic_GridDetalle.ThemeName = "Office2010Black"
        '
        'uic_Precio
        '
        Me.uic_Precio.AcceptsTab = True
        Me.uic_Precio.HideSelection = False
        Me.uic_Precio.Location = New System.Drawing.Point(580, 30)
        Me.uic_Precio.MaxLength = 12
        Me.uic_Precio.Name = "uic_Precio"
        Me.uic_Precio.Size = New System.Drawing.Size(63, 20)
        Me.uic_Precio.TabIndex = 20
        Me.uic_Precio.ThemeName = "Office2010Black"
        Me.uic_Precio.WordWrap = False
        '
        'RadLabel9
        '
        Me.RadLabel9.AutoSize = False
        Me.RadLabel9.BorderVisible = True
        Me.RadLabel9.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel9.Location = New System.Drawing.Point(580, 6)
        Me.RadLabel9.Name = "RadLabel9"
        Me.RadLabel9.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel9.TabIndex = 21
        Me.RadLabel9.Text = "Precio"
        Me.RadLabel9.ThemeName = "office2010blacktheme1"
        '
        'uic_Cantidad
        '
        Me.uic_Cantidad.AcceptsTab = True
        Me.uic_Cantidad.HideSelection = False
        Me.uic_Cantidad.Location = New System.Drawing.Point(509, 30)
        Me.uic_Cantidad.MaxLength = 4
        Me.uic_Cantidad.Name = "uic_Cantidad"
        Me.uic_Cantidad.Size = New System.Drawing.Size(63, 20)
        Me.uic_Cantidad.TabIndex = 18
        Me.uic_Cantidad.ThemeName = "Office2010Black"
        Me.uic_Cantidad.WordWrap = False
        '
        'RadLabel8
        '
        Me.RadLabel8.AutoSize = False
        Me.RadLabel8.BorderVisible = True
        Me.RadLabel8.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel8.Location = New System.Drawing.Point(509, 6)
        Me.RadLabel8.Name = "RadLabel8"
        Me.RadLabel8.Size = New System.Drawing.Size(63, 18)
        Me.RadLabel8.TabIndex = 19
        Me.RadLabel8.Text = "Cantidad"
        Me.RadLabel8.ThemeName = "office2010blacktheme1"
        '
        'uic_Producto
        '
        Me.uic_Producto.AcceptsTab = True
        Me.uic_Producto.HideSelection = False
        Me.uic_Producto.Location = New System.Drawing.Point(150, 30)
        Me.uic_Producto.MaxLength = 80
        Me.uic_Producto.Name = "uic_Producto"
        Me.uic_Producto.Size = New System.Drawing.Size(303, 20)
        Me.uic_Producto.TabIndex = 16
        Me.uic_Producto.ThemeName = "Office2010Black"
        Me.uic_Producto.WordWrap = False
        '
        'RadLabel7
        '
        Me.RadLabel7.AutoSize = False
        Me.RadLabel7.BorderVisible = True
        Me.RadLabel7.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel7.Location = New System.Drawing.Point(150, 6)
        Me.RadLabel7.Name = "RadLabel7"
        Me.RadLabel7.Size = New System.Drawing.Size(303, 18)
        Me.RadLabel7.TabIndex = 17
        Me.RadLabel7.Text = "Producto"
        Me.RadLabel7.ThemeName = "office2010blacktheme1"
        '
        'uic_CodigoProducto
        '
        Me.uic_CodigoProducto.AcceptsTab = True
        Me.uic_CodigoProducto.HideSelection = False
        Me.uic_CodigoProducto.Location = New System.Drawing.Point(8, 30)
        Me.uic_CodigoProducto.MaxLength = 30
        Me.uic_CodigoProducto.Name = "uic_CodigoProducto"
        Me.uic_CodigoProducto.Size = New System.Drawing.Size(99, 20)
        Me.uic_CodigoProducto.TabIndex = 14
        Me.uic_CodigoProducto.ThemeName = "Office2010Black"
        Me.uic_CodigoProducto.WordWrap = False
        '
        'RadLabel5
        '
        Me.RadLabel5.AutoSize = False
        Me.RadLabel5.BorderVisible = True
        Me.RadLabel5.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel5.Location = New System.Drawing.Point(8, 6)
        Me.RadLabel5.Name = "RadLabel5"
        Me.RadLabel5.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel5.TabIndex = 15
        Me.RadLabel5.Text = "Codigo"
        Me.RadLabel5.ThemeName = "office2010blacktheme1"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RadLabel16)
        Me.TabPage2.Controls.Add(Me.uic_Recargo)
        Me.TabPage2.Controls.Add(Me.uic_Exento)
        Me.TabPage2.Controls.Add(Me.Chk_Exento)
        Me.TabPage2.Controls.Add(Me.RadLabel14)
        Me.TabPage2.Controls.Add(Me.uic_Porciento)
        Me.TabPage2.Controls.Add(Me.uic_GrillaDescuento)
        Me.TabPage2.Controls.Add(Me.uic_AgregaDescuento)
        Me.TabPage2.Controls.Add(Me.uic_RazonDescuento)
        Me.TabPage2.Controls.Add(Me.RadLabel17)
        Me.TabPage2.Controls.Add(Me.uic_ValorDescuento)
        Me.TabPage2.Controls.Add(Me.RadLabel18)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(695, 359)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Descuento"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RadLabel16
        '
        Me.RadLabel16.AutoSize = False
        Me.RadLabel16.BorderVisible = True
        Me.RadLabel16.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel16.Location = New System.Drawing.Point(523, 7)
        Me.RadLabel16.Name = "RadLabel16"
        Me.RadLabel16.Size = New System.Drawing.Size(50, 18)
        Me.RadLabel16.TabIndex = 43
        Me.RadLabel16.Text = "Recargo"
        Me.RadLabel16.ThemeName = "office2010blacktheme1"
        '
        'uic_Recargo
        '
        Me.uic_Recargo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_Recargo.Location = New System.Drawing.Point(537, 31)
        Me.uic_Recargo.Name = "uic_Recargo"
        Me.uic_Recargo.Size = New System.Drawing.Size(15, 15)
        Me.uic_Recargo.TabIndex = 42
        Me.uic_Recargo.ThemeName = "Office2010Black"
        '
        'uic_Exento
        '
        Me.uic_Exento.AutoSize = False
        Me.uic_Exento.BorderVisible = True
        Me.uic_Exento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_Exento.Location = New System.Drawing.Point(150, 6)
        Me.uic_Exento.Name = "uic_Exento"
        Me.uic_Exento.Size = New System.Drawing.Size(45, 18)
        Me.uic_Exento.TabIndex = 41
        Me.uic_Exento.Text = "Exento"
        Me.uic_Exento.ThemeName = "office2010blacktheme1"
        '
        'Chk_Exento
        '
        Me.Chk_Exento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.Chk_Exento.Location = New System.Drawing.Point(158, 30)
        Me.Chk_Exento.Name = "Chk_Exento"
        Me.Chk_Exento.Size = New System.Drawing.Size(15, 15)
        Me.Chk_Exento.TabIndex = 40
        Me.Chk_Exento.ThemeName = "Office2010Black"
        '
        'RadLabel14
        '
        Me.RadLabel14.AutoSize = False
        Me.RadLabel14.BorderVisible = True
        Me.RadLabel14.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.RadLabel14.Location = New System.Drawing.Point(116, 7)
        Me.RadLabel14.Name = "RadLabel14"
        Me.RadLabel14.Size = New System.Drawing.Size(24, 18)
        Me.RadLabel14.TabIndex = 39
        Me.RadLabel14.Text = "%"
        Me.RadLabel14.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.RadLabel14.ThemeName = "office2010blacktheme1"
        '
        'uic_Porciento
        '
        Me.uic_Porciento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_Porciento.Location = New System.Drawing.Point(120, 31)
        Me.uic_Porciento.Name = "uic_Porciento"
        Me.uic_Porciento.Size = New System.Drawing.Size(15, 15)
        Me.uic_Porciento.TabIndex = 38
        Me.uic_Porciento.ThemeName = "Office2010Black"
        '
        'uic_GrillaDescuento
        '
        Me.uic_GrillaDescuento.BackColor = System.Drawing.SystemColors.Control
        Me.uic_GrillaDescuento.Cursor = System.Windows.Forms.Cursors.Default
        Me.uic_GrillaDescuento.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.uic_GrillaDescuento.ForeColor = System.Drawing.SystemColors.ControlText
        Me.uic_GrillaDescuento.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.uic_GrillaDescuento.Location = New System.Drawing.Point(6, 60)
        '
        '
        '
        Me.uic_GrillaDescuento.MasterTemplate.AllowAddNewRow = False
        Me.uic_GrillaDescuento.MasterTemplate.AutoGenerateColumns = False
        GridViewTextBoxColumn7.EnableExpressionEditor = False
        GridViewTextBoxColumn7.FieldName = "RutCliente"
        GridViewTextBoxColumn7.HeaderText = "Tipo"
        GridViewTextBoxColumn7.IsAutoGenerated = True
        GridViewTextBoxColumn7.Name = "TipoMov"
        GridViewTextBoxColumn7.Width = 31
        GridViewTextBoxColumn8.EnableExpressionEditor = False
        GridViewTextBoxColumn8.FieldName = "CodInternoCliente"
        GridViewTextBoxColumn8.HeaderText = "Descuento"
        GridViewTextBoxColumn8.IsAutoGenerated = True
        GridViewTextBoxColumn8.Name = "MontoDescuento"
        GridViewTextBoxColumn8.Width = 100
        GridViewTextBoxColumn9.EnableExpressionEditor = False
        GridViewTextBoxColumn9.HeaderText = "Razon"
        GridViewTextBoxColumn9.Name = "RazonDescuento"
        GridViewTextBoxColumn9.Width = 150
        GridViewTextBoxColumn10.EnableExpressionEditor = False
        GridViewTextBoxColumn10.FieldName = "RazonSocialCliente"
        GridViewTextBoxColumn10.HeaderText = "Tipo"
        GridViewTextBoxColumn10.IsAutoGenerated = True
        GridViewTextBoxColumn10.Name = "TipoDescuento"
        GridViewTextBoxColumn10.TextAlignment = System.Drawing.ContentAlignment.MiddleRight
        GridViewTextBoxColumn10.Width = 80
        GridViewCheckBoxColumn1.EnableExpressionEditor = False
        GridViewCheckBoxColumn1.HeaderText = "Exento"
        GridViewCheckBoxColumn1.MinWidth = 20
        GridViewCheckBoxColumn1.Name = "Exento"
        GridViewCommandColumn2.EnableExpressionEditor = False
        GridViewCommandColumn2.HeaderText = "Eliminar"
        GridViewCommandColumn2.Name = "Eliminar"
        GridViewCommandColumn2.Width = 75
        Me.uic_GrillaDescuento.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewTextBoxColumn7, GridViewTextBoxColumn8, GridViewTextBoxColumn9, GridViewTextBoxColumn10, GridViewCheckBoxColumn1, GridViewCommandColumn2})
        Me.uic_GrillaDescuento.MasterTemplate.ViewDefinition = TableViewDefinition2
        Me.uic_GrillaDescuento.Name = "uic_GrillaDescuento"
        Me.uic_GrillaDescuento.ReadOnly = True
        Me.uic_GrillaDescuento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.uic_GrillaDescuento.Size = New System.Drawing.Size(681, 293)
        Me.uic_GrillaDescuento.TabIndex = 37
        Me.uic_GrillaDescuento.ThemeName = "Office2010Black"
        '
        'uic_RazonDescuento
        '
        Me.uic_RazonDescuento.AcceptsTab = True
        Me.uic_RazonDescuento.HideSelection = False
        Me.uic_RazonDescuento.Location = New System.Drawing.Point(214, 30)
        Me.uic_RazonDescuento.MaxLength = 80
        Me.uic_RazonDescuento.Name = "uic_RazonDescuento"
        Me.uic_RazonDescuento.Size = New System.Drawing.Size(303, 20)
        Me.uic_RazonDescuento.TabIndex = 29
        Me.uic_RazonDescuento.ThemeName = "Office2010Black"
        Me.uic_RazonDescuento.WordWrap = False
        '
        'RadLabel17
        '
        Me.RadLabel17.AutoSize = False
        Me.RadLabel17.BorderVisible = True
        Me.RadLabel17.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel17.Location = New System.Drawing.Point(214, 6)
        Me.RadLabel17.Name = "RadLabel17"
        Me.RadLabel17.Size = New System.Drawing.Size(303, 18)
        Me.RadLabel17.TabIndex = 30
        Me.RadLabel17.Text = "Razon Descuento"
        Me.RadLabel17.ThemeName = "office2010blacktheme1"
        '
        'uic_ValorDescuento
        '
        Me.uic_ValorDescuento.AcceptsTab = True
        Me.uic_ValorDescuento.HideSelection = False
        Me.uic_ValorDescuento.Location = New System.Drawing.Point(6, 30)
        Me.uic_ValorDescuento.MaxLength = 30
        Me.uic_ValorDescuento.Name = "uic_ValorDescuento"
        Me.uic_ValorDescuento.Size = New System.Drawing.Size(99, 20)
        Me.uic_ValorDescuento.TabIndex = 27
        Me.uic_ValorDescuento.ThemeName = "Office2010Black"
        Me.uic_ValorDescuento.WordWrap = False
        '
        'RadLabel18
        '
        Me.RadLabel18.AutoSize = False
        Me.RadLabel18.BorderVisible = True
        Me.RadLabel18.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel18.Location = New System.Drawing.Point(6, 6)
        Me.RadLabel18.Name = "RadLabel18"
        Me.RadLabel18.Size = New System.Drawing.Size(99, 18)
        Me.RadLabel18.TabIndex = 28
        Me.RadLabel18.Text = "Valor Descuento"
        Me.RadLabel18.ThemeName = "office2010blacktheme1"
        '
        'RadGroupBox3
        '
        Me.RadGroupBox3.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox3.Controls.Add(Me.uic_TotalRecargo)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel20)
        Me.RadGroupBox3.Controls.Add(Me.uic_TotalDescuento)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel19)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel15)
        Me.RadGroupBox3.Controls.Add(Me.uic_montoExento)
        Me.RadGroupBox3.Controls.Add(Me.uic_IVA)
        Me.RadGroupBox3.Controls.Add(Me.uic_Total_Doc)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel11)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel12)
        Me.RadGroupBox3.Controls.Add(Me.RadLabel13)
        Me.RadGroupBox3.Controls.Add(Me.uic_Neto)
        Me.RadGroupBox3.HeaderText = ""
        Me.RadGroupBox3.Location = New System.Drawing.Point(4, 550)
        Me.RadGroupBox3.Name = "RadGroupBox3"
        Me.RadGroupBox3.Size = New System.Drawing.Size(719, 143)
        Me.RadGroupBox3.TabIndex = 3
        Me.RadGroupBox3.ThemeName = "Office2010Black"
        '
        'uic_TotalRecargo
        '
        Me.uic_TotalRecargo.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_TotalRecargo.Location = New System.Drawing.Point(126, 56)
        Me.uic_TotalRecargo.MaxLength = 10
        Me.uic_TotalRecargo.Name = "uic_TotalRecargo"
        Me.uic_TotalRecargo.ReadOnly = True
        Me.uic_TotalRecargo.Size = New System.Drawing.Size(105, 20)
        Me.uic_TotalRecargo.TabIndex = 20
        Me.uic_TotalRecargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_TotalRecargo.ThemeName = "Office2010Black"
        '
        'RadLabel20
        '
        Me.RadLabel20.AutoSize = False
        Me.RadLabel20.BorderVisible = True
        Me.RadLabel20.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel20.Location = New System.Drawing.Point(21, 56)
        Me.RadLabel20.Name = "RadLabel20"
        Me.RadLabel20.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel20.TabIndex = 19
        Me.RadLabel20.Text = "Recargo"
        Me.RadLabel20.ThemeName = "office2010blacktheme1"
        '
        'uic_TotalDescuento
        '
        Me.uic_TotalDescuento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_TotalDescuento.Location = New System.Drawing.Point(126, 32)
        Me.uic_TotalDescuento.MaxLength = 10
        Me.uic_TotalDescuento.Name = "uic_TotalDescuento"
        Me.uic_TotalDescuento.ReadOnly = True
        Me.uic_TotalDescuento.Size = New System.Drawing.Size(105, 20)
        Me.uic_TotalDescuento.TabIndex = 18
        Me.uic_TotalDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_TotalDescuento.ThemeName = "Office2010Black"
        '
        'RadLabel19
        '
        Me.RadLabel19.AutoSize = False
        Me.RadLabel19.BorderVisible = True
        Me.RadLabel19.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel19.Location = New System.Drawing.Point(21, 32)
        Me.RadLabel19.Name = "RadLabel19"
        Me.RadLabel19.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel19.TabIndex = 17
        Me.RadLabel19.Text = "Descuento"
        Me.RadLabel19.ThemeName = "office2010blacktheme1"
        '
        'RadLabel15
        '
        Me.RadLabel15.AutoSize = False
        Me.RadLabel15.BorderVisible = True
        Me.RadLabel15.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel15.Location = New System.Drawing.Point(248, 56)
        Me.RadLabel15.Name = "RadLabel15"
        Me.RadLabel15.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel15.TabIndex = 16
        Me.RadLabel15.Text = "Monto Exento"
        Me.RadLabel15.ThemeName = "office2010blacktheme1"
        '
        'uic_montoExento
        '
        Me.uic_montoExento.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_montoExento.Location = New System.Drawing.Point(353, 54)
        Me.uic_montoExento.MaxLength = 10
        Me.uic_montoExento.Name = "uic_montoExento"
        Me.uic_montoExento.ReadOnly = True
        Me.uic_montoExento.Size = New System.Drawing.Size(105, 20)
        Me.uic_montoExento.TabIndex = 15
        Me.uic_montoExento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_montoExento.ThemeName = "Office2010Black"
        '
        'uic_IVA
        '
        Me.uic_IVA.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_IVA.Location = New System.Drawing.Point(353, 80)
        Me.uic_IVA.MaxLength = 10
        Me.uic_IVA.Name = "uic_IVA"
        Me.uic_IVA.ReadOnly = True
        Me.uic_IVA.Size = New System.Drawing.Size(105, 20)
        Me.uic_IVA.TabIndex = 14
        Me.uic_IVA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_IVA.ThemeName = "Office2010Black"
        '
        'uic_Total_Doc
        '
        Me.uic_Total_Doc.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_Total_Doc.Location = New System.Drawing.Point(595, 103)
        Me.uic_Total_Doc.MaxLength = 10
        Me.uic_Total_Doc.Name = "uic_Total_Doc"
        Me.uic_Total_Doc.ReadOnly = True
        Me.uic_Total_Doc.Size = New System.Drawing.Size(105, 20)
        Me.uic_Total_Doc.TabIndex = 6
        Me.uic_Total_Doc.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_Total_Doc.ThemeName = "Office2010Black"
        '
        'RadLabel11
        '
        Me.RadLabel11.AutoSize = False
        Me.RadLabel11.BorderVisible = True
        Me.RadLabel11.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel11.Location = New System.Drawing.Point(490, 103)
        Me.RadLabel11.Name = "RadLabel11"
        Me.RadLabel11.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel11.TabIndex = 13
        Me.RadLabel11.Text = "Total "
        Me.RadLabel11.ThemeName = "office2010blacktheme1"
        '
        'RadLabel12
        '
        Me.RadLabel12.AutoSize = False
        Me.RadLabel12.BorderVisible = True
        Me.RadLabel12.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel12.Location = New System.Drawing.Point(248, 80)
        Me.RadLabel12.Name = "RadLabel12"
        Me.RadLabel12.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel12.TabIndex = 12
        Me.RadLabel12.Text = "I.V.A."
        Me.RadLabel12.ThemeName = "office2010blacktheme1"
        '
        'RadLabel13
        '
        Me.RadLabel13.AutoSize = False
        Me.RadLabel13.BorderVisible = True
        Me.RadLabel13.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel13.Location = New System.Drawing.Point(248, 32)
        Me.RadLabel13.Name = "RadLabel13"
        Me.RadLabel13.Size = New System.Drawing.Size(97, 18)
        Me.RadLabel13.TabIndex = 10
        Me.RadLabel13.Text = "Monto Neto"
        Me.RadLabel13.ThemeName = "office2010blacktheme1"
        '
        'uic_Neto
        '
        Me.uic_Neto.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.uic_Neto.Location = New System.Drawing.Point(353, 30)
        Me.uic_Neto.MaxLength = 10
        Me.uic_Neto.Name = "uic_Neto"
        Me.uic_Neto.ReadOnly = True
        Me.uic_Neto.Size = New System.Drawing.Size(105, 20)
        Me.uic_Neto.TabIndex = 8
        Me.uic_Neto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.uic_Neto.ThemeName = "Office2010Black"
        '
        'Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(739, 699)
        Me.Controls.Add(Me.RadGroupBox3)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Facturas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Facturas"
        CType(Me.FormaDePagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.uic_Vendedor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_observaciones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_FechaEmision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_rut, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_RazonSocial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.uic_UM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_GridDetalle.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_GridDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Precio, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Cantidad, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Producto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_CodigoProducto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.RadLabel16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Recargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Exento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chk_Exento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Porciento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_GrillaDescuento.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_GrillaDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_RazonDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_ValorDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox3.ResumeLayout(False)
        Me.RadGroupBox3.PerformLayout()
        CType(Me.uic_TotalRecargo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_TotalDescuento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_montoExento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_IVA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Total_Doc, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.uic_Neto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents DTESISTEMDataSet As SistemaDte.DTESISTEMDataSet
    Friend WithEvents FormaDePagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormaDePagoTableAdapter As SistemaDte.DTESISTEMDataSetTableAdapters.FormaDePagoTableAdapter
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_buscarCliente As System.Windows.Forms.Button
    Friend WithEvents uic_RazonSocial As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel6 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_rut As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uic_observaciones As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel4 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel3 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel2 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_FechaEmision As Telerik.WinControls.UI.RadDateTimePicker
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Vendedor As Telerik.WinControls.UI.RadDropDownList
    Friend WithEvents uic_Formapago As System.Windows.Forms.ComboBox
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGroupBox3 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents uic_IVA As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uic_Total_Doc As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel11 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel12 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel13 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Neto As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents uic_GridDetalle As Telerik.WinControls.UI.RadGridView
    Friend WithEvents uic_AgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents uic_BuscarProducto As System.Windows.Forms.Button
    Friend WithEvents uic_Precio As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel9 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Cantidad As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel8 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Producto As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel7 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_CodigoProducto As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel5 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents uic_UM As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel10 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_GrillaDescuento As Telerik.WinControls.UI.RadGridView
    Friend WithEvents uic_AgregaDescuento As System.Windows.Forms.Button
    Friend WithEvents uic_RazonDescuento As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel17 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_ValorDescuento As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel18 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadLabel16 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Recargo As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents uic_Exento As Telerik.WinControls.UI.RadLabel
    Friend WithEvents Chk_Exento As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel14 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Porciento As Telerik.WinControls.UI.RadCheckBox
    Friend WithEvents RadLabel15 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_montoExento As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uic_TotalRecargo As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel20 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_TotalDescuento As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents RadLabel19 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents uic_Salir As System.Windows.Forms.Button
    Friend WithEvents uic_Limpiar As System.Windows.Forms.Button
    Friend WithEvents uic_GrabaDTE As System.Windows.Forms.Button
End Class
