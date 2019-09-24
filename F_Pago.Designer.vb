<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class F_Pago
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
        Dim GridViewDecimalColumn1 As Telerik.WinControls.UI.GridViewDecimalColumn = New Telerik.WinControls.UI.GridViewDecimalColumn()
        Dim GridViewTextBoxColumn1 As Telerik.WinControls.UI.GridViewTextBoxColumn = New Telerik.WinControls.UI.GridViewTextBoxColumn()
        Dim TableViewDefinition1 As Telerik.WinControls.UI.TableViewDefinition = New Telerik.WinControls.UI.TableViewDefinition()
        Me.FormaDePagoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTESISTEMDataSet = New SistemaDte.DTESISTEMDataSet()
        Me.FormaDePagoTableAdapter = New SistemaDte.DTESISTEMDataSetTableAdapters.FormaDePagoTableAdapter()
        Me.RadGroupBox1 = New Telerik.WinControls.UI.RadGroupBox()
        Me.uic_grabaEstaciones = New System.Windows.Forms.Button()
        Me.uic_F_Pago = New Telerik.WinControls.UI.RadTextBox()
        Me.RadLabel1 = New Telerik.WinControls.UI.RadLabel()
        Me.RadGroupBox2 = New Telerik.WinControls.UI.RadGroupBox()
        Me.RadGridView1 = New Telerik.WinControls.UI.RadGridView()
        Me.Office2010BlackTheme1 = New Telerik.WinControls.Themes.Office2010BlackTheme()
        Me.uic_Salir = New System.Windows.Forms.Button()
        CType(Me.FormaDePagoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox1.SuspendLayout()
        CType(Me.uic_F_Pago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.RadGroupBox2.SuspendLayout()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'FormaDePagoTableAdapter
        '
        Me.FormaDePagoTableAdapter.ClearBeforeFill = True
        '
        'RadGroupBox1
        '
        Me.RadGroupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox1.Controls.Add(Me.uic_grabaEstaciones)
        Me.RadGroupBox1.Controls.Add(Me.uic_F_Pago)
        Me.RadGroupBox1.Controls.Add(Me.RadLabel1)
        Me.RadGroupBox1.HeaderText = ""
        Me.RadGroupBox1.Location = New System.Drawing.Point(9, 6)
        Me.RadGroupBox1.Name = "RadGroupBox1"
        Me.RadGroupBox1.Size = New System.Drawing.Size(319, 78)
        Me.RadGroupBox1.TabIndex = 2
        Me.RadGroupBox1.ThemeName = "Office2010Black"
        '
        'uic_grabaEstaciones
        '
        Me.uic_grabaEstaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_grabaEstaciones.Image = Global.SistemaDte.My.Resources.Resources.disk_blue2
        Me.uic_grabaEstaciones.Location = New System.Drawing.Point(267, 22)
        Me.uic_grabaEstaciones.Name = "uic_grabaEstaciones"
        Me.uic_grabaEstaciones.Size = New System.Drawing.Size(34, 32)
        Me.uic_grabaEstaciones.TabIndex = 25
        Me.uic_grabaEstaciones.UseVisualStyleBackColor = True
        '
        'uic_F_Pago
        '
        Me.uic_F_Pago.Location = New System.Drawing.Point(86, 28)
        Me.uic_F_Pago.MaxLength = 10
        Me.uic_F_Pago.Name = "uic_F_Pago"
        Me.uic_F_Pago.Size = New System.Drawing.Size(165, 20)
        Me.uic_F_Pago.TabIndex = 4
        Me.uic_F_Pago.ThemeName = "Office2010Black"
        '
        'RadLabel1
        '
        Me.RadLabel1.AutoSize = False
        Me.RadLabel1.BorderVisible = True
        Me.RadLabel1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Bold)
        Me.RadLabel1.Location = New System.Drawing.Point(6, 30)
        Me.RadLabel1.Name = "RadLabel1"
        Me.RadLabel1.Size = New System.Drawing.Size(71, 18)
        Me.RadLabel1.TabIndex = 1
        Me.RadLabel1.Text = "Forma Pago"
        Me.RadLabel1.ThemeName = "office2010blacktheme1"
        '
        'RadGroupBox2
        '
        Me.RadGroupBox2.AccessibleRole = System.Windows.Forms.AccessibleRole.Grouping
        Me.RadGroupBox2.Controls.Add(Me.uic_Salir)
        Me.RadGroupBox2.Controls.Add(Me.RadGridView1)
        Me.RadGroupBox2.HeaderText = ""
        Me.RadGroupBox2.Location = New System.Drawing.Point(9, 90)
        Me.RadGroupBox2.Name = "RadGroupBox2"
        Me.RadGroupBox2.Size = New System.Drawing.Size(319, 326)
        Me.RadGroupBox2.TabIndex = 3
        Me.RadGroupBox2.ThemeName = "Office2010Black"
        '
        'RadGridView1
        '
        Me.RadGridView1.BackColor = System.Drawing.SystemColors.Control
        Me.RadGridView1.Cursor = System.Windows.Forms.Cursors.Default
        Me.RadGridView1.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.RadGridView1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.RadGridView1.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.RadGridView1.Location = New System.Drawing.Point(13, 12)
        '
        '
        '
        GridViewDecimalColumn1.DataType = GetType(Integer)
        GridViewDecimalColumn1.EnableExpressionEditor = False
        GridViewDecimalColumn1.FieldName = "id"
        GridViewDecimalColumn1.HeaderText = "id"
        GridViewDecimalColumn1.IsAutoGenerated = True
        GridViewDecimalColumn1.IsVisible = False
        GridViewDecimalColumn1.Name = "id"
        GridViewDecimalColumn1.ReadOnly = True
        GridViewTextBoxColumn1.EnableExpressionEditor = False
        GridViewTextBoxColumn1.FieldName = "F_Pago"
        GridViewTextBoxColumn1.HeaderText = "F_Pago"
        GridViewTextBoxColumn1.IsAutoGenerated = True
        GridViewTextBoxColumn1.Name = "F_Pago"
        GridViewTextBoxColumn1.Width = 155
        Me.RadGridView1.MasterTemplate.Columns.AddRange(New Telerik.WinControls.UI.GridViewDataColumn() {GridViewDecimalColumn1, GridViewTextBoxColumn1})
        Me.RadGridView1.MasterTemplate.DataSource = Me.FormaDePagoBindingSource
        Me.RadGridView1.MasterTemplate.ViewDefinition = TableViewDefinition1
        Me.RadGridView1.Name = "RadGridView1"
        Me.RadGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.RadGridView1.Size = New System.Drawing.Size(219, 297)
        Me.RadGridView1.TabIndex = 0
        Me.RadGridView1.Text = "RadGridView1"
        Me.RadGridView1.ThemeName = "Office2010Black"
        '
        'uic_Salir
        '
        Me.uic_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_Salir.Image = Global.SistemaDte.My.Resources.Resources.exit2
        Me.uic_Salir.Location = New System.Drawing.Point(267, 12)
        Me.uic_Salir.Name = "uic_Salir"
        Me.uic_Salir.Size = New System.Drawing.Size(36, 36)
        Me.uic_Salir.TabIndex = 20
        Me.uic_Salir.UseVisualStyleBackColor = True
        '
        'F_Pago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(394, 428)
        Me.Controls.Add(Me.RadGroupBox2)
        Me.Controls.Add(Me.RadGroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "F_Pago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Forma de pago"
        CType(Me.FormaDePagoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DTESISTEMDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox1.ResumeLayout(False)
        Me.RadGroupBox1.PerformLayout()
        CType(Me.uic_F_Pago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadLabel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGroupBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.RadGroupBox2.ResumeLayout(False)
        CType(Me.RadGridView1.MasterTemplate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RadGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DTESISTEMDataSet As SistemaDte.DTESISTEMDataSet
    Friend WithEvents FormaDePagoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents FormaDePagoTableAdapter As SistemaDte.DTESISTEMDataSetTableAdapters.FormaDePagoTableAdapter
    Friend WithEvents RadGroupBox1 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadLabel1 As Telerik.WinControls.UI.RadLabel
    Friend WithEvents RadGroupBox2 As Telerik.WinControls.UI.RadGroupBox
    Friend WithEvents RadGridView1 As Telerik.WinControls.UI.RadGridView
    Friend WithEvents Office2010BlackTheme1 As Telerik.WinControls.Themes.Office2010BlackTheme
    Friend WithEvents uic_F_Pago As Telerik.WinControls.UI.RadTextBox
    Friend WithEvents uic_grabaEstaciones As System.Windows.Forms.Button
    Friend WithEvents uic_Salir As System.Windows.Forms.Button
End Class
