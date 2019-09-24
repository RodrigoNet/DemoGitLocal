Namespace dac
    Public Class Sucursal
        Public Function grabaSucursal(ByVal dts As be.Sucursal) As String
            Try
                Dim osql As New dac.myMSSQL(My.Settings.facturaConnectionString, 60000)
                Dim resp As String = ""

                osql.paramQUERY.Add("telefono", dts.get_fono)

                resp = osql.GetValorNoNull("Graba_Sucursal")
                If osql.DioError Then
                    Return osql.MsgError
                End If
                If resp <> "OK" Then
                    Return "Error al crear Sucursal " & resp
                End If
                Return "OK"
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ex.Message
            End Try
        End Function

    End Class

End Namespace
