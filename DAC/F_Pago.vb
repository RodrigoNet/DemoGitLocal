Namespace dac
    Public Class F_Pago
        Public Function graba_F_Pago(ByVal dts As be.F_Pago) As String
            Try
                Dim osql As New dac.myMSSQL(My.Settings.facturaConnectionString, 60000)
                Dim resp As String = ""

                osql.paramQUERY.Add("F_Pago", dts.get_F_Pago)

                osql.Ejecuta("Graba_F_Pago")

                'resp = osql.GetValorNoNull("Graba_F_Pago")
                If osql.DioError Then
                    Return osql.MsgError
                End If
                'If resp <> "OK" Then
                'Return "Error al grabar forma de pago " & resp
                'End If
                Return "OK"
            Catch ex As Exception
                MsgBox(ex.Message)
                Return ex.Message
            End Try
        End Function
    End Class

End Namespace
