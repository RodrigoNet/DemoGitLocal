<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TB_Usuario
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
        Me.uic_Roles = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.uic_ValidaClave = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.uic_Clave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.uic_Usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.uic_grabaEstaciones = New System.Windows.Forms.Button()
        Me.uic_Sucursal = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.uic_Sucursal)
        Me.GroupBox1.Controls.Add(Me.uic_Roles)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.uic_grabaEstaciones)
        Me.GroupBox1.Controls.Add(Me.uic_ValidaClave)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.uic_Clave)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.uic_Usuario)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(457, 192)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'uic_Roles
        '
        Me.uic_Roles.FormattingEnabled = True
        Me.uic_Roles.Location = New System.Drawing.Point(108, 160)
        Me.uic_Roles.Name = "uic_Roles"
        Me.uic_Roles.Size = New System.Drawing.Size(130, 21)
        Me.uic_Roles.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 160)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 19)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Rol Usuario"
        '
        'uic_ValidaClave
        '
        Me.uic_ValidaClave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.uic_ValidaClave.Location = New System.Drawing.Point(108, 122)
        Me.uic_ValidaClave.MaxLength = 10
        Me.uic_ValidaClave.Name = "uic_ValidaClave"
        Me.uic_ValidaClave.PasswordChar = Global.Microsoft.VisualBasic.ChrW(88)
        Me.uic_ValidaClave.Size = New System.Drawing.Size(130, 20)
        Me.uic_ValidaClave.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(8, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Repita Clave"
        '
        'uic_Clave
        '
        Me.uic_Clave.Location = New System.Drawing.Point(108, 85)
        Me.uic_Clave.MaxLength = 10
        Me.uic_Clave.Name = "uic_Clave"
        Me.uic_Clave.Size = New System.Drawing.Size(130, 20)
        Me.uic_Clave.TabIndex = 14
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(8, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 19)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Clave"
        '
        'uic_Usuario
        '
        Me.uic_Usuario.Location = New System.Drawing.Point(108, 50)
        Me.uic_Usuario.MaxLength = 10
        Me.uic_Usuario.Name = "uic_Usuario"
        Me.uic_Usuario.Size = New System.Drawing.Size(337, 20)
        Me.uic_Usuario.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(99, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Usuario"
        '
        'uic_grabaEstaciones
        '
        Me.uic_grabaEstaciones.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.uic_grabaEstaciones.Image = Global.SistemaDte.My.Resources.Resources.disk_blue2
        Me.uic_grabaEstaciones.Location = New System.Drawing.Point(305, 144)
        Me.uic_grabaEstaciones.Name = "uic_grabaEstaciones"
        Me.uic_grabaEstaciones.Size = New System.Drawing.Size(34, 32)
        Me.uic_grabaEstaciones.TabIndex = 25
        Me.uic_grabaEstaciones.UseVisualStyleBackColor = True
        '
        'uic_Sucursal
        '
        Me.uic_Sucursal.FormattingEnabled = True
        Me.uic_Sucursal.Location = New System.Drawing.Point(108, 19)
        Me.uic_Sucursal.Name = "uic_Sucursal"
        Me.uic_Sucursal.Size = New System.Drawing.Size(130, 21)
        Me.uic_Sucursal.TabIndex = 28
        '
        'Label4
        '
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 19)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Sucursal"
        '
        'TB_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 208)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TB_Usuario"
        Me.Text = "Usuario"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents uic_Roles As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents uic_grabaEstaciones As System.Windows.Forms.Button
    Friend WithEvents uic_ValidaClave As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents uic_Clave As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents uic_Usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents uic_Sucursal As System.Windows.Forms.ComboBox
End Class
