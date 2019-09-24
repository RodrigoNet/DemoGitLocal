Namespace dac
    Public Class Productos
        Public Function grabaProducto(ByVal dts As be.Productos) As String
            Try
                Dim osql As New dac.myMSSQL(My.Settings.facturaConnectionString, 60000)
                Dim resp As String = ""

                osql.paramQUERY.Add("CodProducto", dts.get_CodProducto)
                osql.paramQUERY.Add("Descripcion", dts.get_Descripcion)
                osql.paramQUERY.Add("InfoAdic", dts.get_InfoAdic)
                osql.paramQUERY.Add("UM", dts.get_UM)
                osql.paramQUERY.Add("Exento", dts.get_exento)
                osql.paramQUERY.Add("CodImpuestoAdic1", dts.get_CodImpuestoAdic1)
                osql.paramQUERY.Add("CodImpuestoAdic2", dts.get_CodImpuestoAdic2)
                osql.paramQUERY.Add("TasaImpAdic1", dts.get_TasaImpAdic1)
                osql.paramQUERY.Add("TasaImpAdic2", dts.get_TasaImpAdic2)
                osql.paramQUERY.Add("Precio", dts.get_Precio)
                osql.paramQUERY.Add("CodigoBarra", dts.get_CodigoBarra)
                osql.paramQUERY.Add("CodigoProveedor", dts.get_CodigoProveedor)
                osql.paramQUERY.Add("CodigoExtra1", dts.get_CodigoExtra1)
                osql.paramQUERY.Add("CodigoExtra2", dts.get_CodigoExtra2)
                osql.paramQUERY.Add("Sucursal", "DEMO")

                resp = osql.GetValorNoNull("Graba_Productos")
                If osql.DioError Then
                    Return osql.MsgError
                End If
                If resp <> "OK" Then
                    Return "Error al crear Productos " & resp
                End If
                Return "OK"
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ex.Message
            End Try
        End Function
    End Class

End Namespace

