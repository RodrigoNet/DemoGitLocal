Namespace dac
    Public Class Clientes
        Public Function grabaCliente(ByVal dts As be.Clientes) As String
            Try
                Dim osql As New dac.myMSSQL(My.Settings.facturaConnectionString, 60000)
                Dim resp As String = ""

                Dim odac As New dac.myhelper3
                odac.paramQUERY.Add("RutCliente", dts.get_rut)
                odac.paramQUERY.Add("CodInternoCliente", dts.get_CodCliente)
                odac.paramQUERY.Add("RazonSocialCliente", dts.get_razonsocial)
                odac.paramQUERY.Add("GiroCliente", dts.get_giro)
                odac.paramQUERY.Add("DireccionCliente", dts.get_direccion)
                odac.paramQUERY.Add("ComunaCliente", dts.get_comuna)
                odac.paramQUERY.Add("CiudadCliente", dts.get_ciudad)
                odac.paramQUERY.Add("EmailPDF", dts.get_emailpdf)
                odac.paramQUERY.Add("EmailXML", dts.get_emailxml)
                odac.paramQUERY.Add("telefono", dts.get_fono)

                'osql.paramQUERY.Add("RutCliente", dts.get_rut)
                'osql.paramQUERY.Add("CodInternoCliente", dts.get_CodCliente)
                'osql.paramQUERY.Add("RazonSocialCliente", dts.get_razonsocial)
                'osql.paramQUERY.Add("GiroCliente", dts.get_giro)
                'osql.paramQUERY.Add("DireccionCliente", dts.get_direccion)
                'osql.paramQUERY.Add("ComunaCliente", dts.get_comuna)
                'osql.paramQUERY.Add("CiudadCliente", dts.get_ciudad)
                'osql.paramQUERY.Add("EmailPDF", dts.get_emailpdf)
                'osql.paramQUERY.Add("EmailXML", dts.get_emailxml)
                'osql.paramQUERY.Add("telefono", dts.get_fono)

                resp = odac.FireAndForget(My.Settings.facturaConnectionString, CommandType.StoredProcedure, "Graba_Clientes", odac.paramQUERY, 180000)
                'resp = osql.GetValorNoNull("Graba_Clientes")
                'osql.Ejecuta("Graba_clientes")
                If osql.DioError Then
                    Return osql.MsgError
                End If
                If resp <> "1" Then ' "OK" Then
                    Return "Error al crear Clientes " & resp
                End If
                Return "OK"
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ex.Message
            End Try
        End Function
        Public Function ModificarCliente(ByVal dts As be.Clientes) As String
            Try
                Dim osql As New dac.myMSSQL(My.Settings.facturaConnectionString, 60000)
                Dim resp As String = ""

                osql.paramQUERY.Add("RutCliente", dts.get_rut)
                osql.paramQUERY.Add("CodInternoCliente", dts.get_CodCliente)
                osql.paramQUERY.Add("RazonSocialCliente", dts.get_razonsocial)
                osql.paramQUERY.Add("GiroCliente", dts.get_giro)
                osql.paramQUERY.Add("DireccionCliente", dts.get_direccion)
                osql.paramQUERY.Add("ComunaCliente", dts.get_comuna)
                osql.paramQUERY.Add("CiudadCliente", dts.get_ciudad)
                osql.paramQUERY.Add("EmailPDF", dts.get_emailpdf)
                osql.paramQUERY.Add("EmailXML", dts.get_emailxml)
                osql.paramQUERY.Add("telefono", dts.get_fono)

                resp = osql.GetValorNoNull("Actualiza_Clientes")

                If osql.DioError Then
                    Return osql.MsgError
                End If
                If resp <> "OK" Then
                    Return "Error al crear Clientes " & resp
                End If
                Return "OK"
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ex.Message
            End Try
        End Function
        Public Function Buscar_Cliente(ByVal p_rutCliente As String) As be.Clientes
            Dim oCliente As New be.Clientes
            Try
                Dim vtabla As New Data.DataTable
                Dim odac As New dac.myhelper3

                odac.paramQUERY.Add("RutCliente", p_rutCliente)
                vtabla = odac.ExecuteDatatable(My.Settings.facturaConnectionString, CommandType.StoredProcedure, "Buscar_Cliente", odac.paramQUERY, 180000)

                oCliente.get_rut = vtabla.Rows(0).Item("RutCliente")
                oCliente.get_CodCliente = vtabla.Rows(0).Item("CodInternoCliente")
                oCliente.get_razonsocial = vtabla.Rows(0).Item("RazonSocialCliente")
                oCliente.get_giro = vtabla.Rows(0).Item("GiroCliente")
                oCliente.get_direccion = vtabla.Rows(0).Item("DireccionCliente")
                oCliente.get_comuna = vtabla.Rows(0).Item("ComunaCliente")
                oCliente.get_ciudad = vtabla.Rows(0).Item("CiudadCliente")
                oCliente.get_emailpdf = vtabla.Rows(0).Item("EmailPDF")
                oCliente.get_emailxml = vtabla.Rows(0).Item("EmailXML")
                oCliente.get_fono = vtabla.Rows(0).Item("telefono")

            Catch ex As Exception

            End Try
            Return oCliente
        End Function
    End Class

End Namespace