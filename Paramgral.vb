Public Class Paramgral
    Dim comando_SQL As String
    Dim rut As New BC.RUTman

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Pruebe Instalar el certificado en el Internet Explorer para verificare si la clave es la correcta")
    End Sub

    Private Sub Paramgral_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Dim lista_param As New Dictionary(Of String, String)
        lista_param = get_lista_paramG()

        Me.uic_rutEmp.Text = lista_param("RUTEmpresa")
        Me.uic_acteco.Text = lista_param("Acteco")
        Me.uic_razonSocial.Text = lista_param("RznSoc")
        Me.uic_giro.Text = lista_param("Giro")
        Me.uic_direccion.Text = lista_param("DirOrigen")
        Me.uic_ciudad.Text = lista_param("CiudadOrigen")
        Me.uic_comuna.Text = lista_param("CmnaOrigen")

        Me.uic_emailEmpresa.Text = lista_param("Email_empresa")
        Me.uic_telefonos.Text = lista_param("Telefonos")

        Me.uic_ambiente.Text = lista_param("Ambiente")
        Me.uic_fechaResol.Text = lista_param("FchResol")
        Me.uic_num_resol.Text = lista_param("NroResol")
        Me.uic_rutCert.Text = lista_param("RUTCert")
        Me.uic_claveCert.Text = lista_param("Clave_Cert")
        Me.Cursor = Cursors.Default
    End Sub

    Public Function get_lista_paramG() As Dictionary(Of String, String)
        Dim odac_hsql As New dac.myhelper3

        Dim resp As New Dictionary(Of String, String)

        Dim tabla_paramG As New DataTable
        tabla_paramG = odac_hsql.ExecuteDatatable(My.Settings.facturaConnectionString, CommandType.Text, "Select * from param_gen", Nothing, 60000)

        For Each elem As DataRow In tabla_paramG.Rows
            resp.Add(elem.Item("nombre_param").ToString.Trim, elem.Item("valor_param").ToString.Trim)
        Next

        Return resp
    End Function

#Region "KeyPress"
    Private Sub uic_rutEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_rutEmp.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            If Not rut.check_es_valido(Me.uic_rutEmp.Text) Then
                MsgBox("Error, RUT no valido", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
    Private Sub uic_acteco_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_acteco.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_razonSocial_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_razonSocial.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_giro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_giro.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_direccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_ciudad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_ciudad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_comuna_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_comuna.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_emailEmpresa_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_emailEmpresa.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_telefonos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_telefonos.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_ambiente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_ambiente.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_fechaResol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_fechaResol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_num_resol_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_num_resol.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
    Private Sub uic_rutCert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_rutCert.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
            If Not rut.check_es_valido(Me.uic_rutCert.Text) Then
                MsgBox("Error, RUT no valido", MsgBoxStyle.Critical, "Error")
            End If
        End If
    End Sub
    Private Sub uic_claveCert_KeyPress(sender As Object, e As KeyPressEventArgs) Handles uic_claveCert.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            e.Handled = True
            SendKeys.Send("{TAB}")
        End If
    End Sub
#End Region

#Region "UpperCase"
    Private Sub uic_rutEmp_TextChanged(sender As Object, e As EventArgs) Handles uic_rutEmp.TextChanged
        Me.uic_rutEmp.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_razonSocial_TextChanged(sender As Object, e As EventArgs) Handles uic_razonSocial.TextChanged
        Me.uic_razonSocial.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_giro_TextChanged(sender As Object, e As EventArgs) Handles uic_giro.TextChanged
        Me.uic_giro.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_direccion_TextChanged(sender As Object, e As EventArgs) Handles uic_direccion.TextChanged
        Me.uic_direccion.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_ciudad_TextChanged(sender As Object, e As EventArgs) Handles uic_ciudad.TextChanged
        Me.uic_ciudad.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_comuna_TextChanged(sender As Object, e As EventArgs) Handles uic_comuna.TextChanged
        Me.uic_comuna.CharacterCasing = CharacterCasing.Upper
    End Sub
    Private Sub uic_ambiente_TextChanged(sender As Object, e As EventArgs) Handles uic_ambiente.TextChanged
        Me.uic_ambiente.CharacterCasing = CharacterCasing.Upper
    End Sub
#End Region

    Private Sub uic_aceptar_Click(sender As Object, e As EventArgs) Handles uic_aceptar.Click
        uic_ambiente.Text = uic_ambiente.Text.Trim.ToUpper
        If uic_ambiente.Text <> "P" And uic_ambiente.Text <> "C" Then
            MsgBox("Ambiente debe ser P o C")
            Exit Sub
        End If

        uic_fechaResol.Text = uic_fechaResol.Text.Trim
        Dim resp As DateTime
        If Not DateTime.TryParseExact(uic_fechaResol.Text, "yyyy-MM-dd", Globalization.CultureInfo.InvariantCulture, Globalization.DateTimeStyles.AssumeUniversal, resp) Then
            MsgBox("Formato Fecha Resolución incorrecto")
            Exit Sub
        End If

        If uic_fechaResol.Text.Substring(0, 4) < 2003 OrElse uic_fechaResol.Text.Substring(0, 4) > 2030 Then
            MsgBox("Año de la fecha de resolución no valido (2003-2030)")
            Exit Sub
        End If

        uic_num_resol.Text = uic_num_resol.Text.Trim
        If uic_num_resol.Text.Length = 0 OrElse Not IsNumeric(uic_num_resol.Text) Then
            MsgBox("Número de resolución no valido")
            Exit Sub
        End If

        If uic_ambiente.Text = "P" And uic_num_resol.Text = 0 Then
            MsgBox("Número de resolución no puede ser cero")
            Exit Sub
        End If

        uic_acteco.Text = uic_acteco.Text.Trim
        If uic_acteco.Text.Contains(" ") OrElse uic_acteco.Text.Length = 0 OrElse uic_acteco.Text.Length > 6 OrElse Not IsNumeric(uic_acteco.Text) Then
            MsgBox("Código ACTECO no valido")
            Exit Sub
        End If

        uic_giro.Text = uic_giro.Text.Trim
        If uic_giro.Text.Length = 0 OrElse uic_giro.Text.Length > 80 Then
            MsgBox("Giro incorrecto")
            Exit Sub
        End If

        comando_SQL = ""
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_acteco.Text.Trim & "'  where nombre_param='Acteco' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_ambiente.Text.Trim & "'  where nombre_param='Ambiente' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_ciudad.Text.Trim & "'  where nombre_param='CiudadOrigen' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_claveCert.Text.Trim & "'  where nombre_param='Clave_Cert' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_comuna.Text.Trim & "'  where nombre_param='CmnaOrigen' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_emailEmpresa.Text.Trim & "'  where nombre_param='CuentaCorreo' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_direccion.Text.Trim & "'  where nombre_param='DirOrigen' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_emailEmpresa.Text.Trim & "'  where nombre_param='Email_empresa' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_fechaResol.Text.Trim & "'  where nombre_param='FchResol' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_giro.Text.Trim & "'  where nombre_param='Giro' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_num_resol.Text.Trim & "'  where nombre_param='NroResol' " & vbCrLf & "GO" & vbCrLf

        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_rutCert.Text.Trim & "'  where nombre_param='RUTCert' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_rutEmp.Text.Trim & "'  where nombre_param='RUTEmpresa' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_razonSocial.Text.Trim & "'  where nombre_param='RznSoc' " & vbCrLf & "GO" & vbCrLf
        comando_SQL &= "Update param_gen set valor_param ='" & Me.uic_telefonos.Text.Trim & "'  where nombre_param='Telefonos' " & vbCrLf & "GO" & vbCrLf


        Dim file_temp As String = Application.StartupPath & "\temp.txt"
        My.Computer.FileSystem.WriteAllText(file_temp, comando_SQL, False)

        Dim odac_runnerScript As New dac.runnerScript
        odac_runnerScript.ejecuta_file_script(My.Settings.facturaConnectionString, file_temp)
        Me.Close()
    End Sub
End Class