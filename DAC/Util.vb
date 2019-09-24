Namespace dac
    Public Class Util
        Public Function GET_FolioDTE(ByVal TipoDTE As Integer, ByVal Sucursal As String) As Integer
            Dim FolioDTE As Integer
            Try
                Dim osql As New dac.myMSSQL(My.Settings.facturaConnectionString, 60000)
                osql.paramQUERY.Add("TipoDoc", TipoDTE)
                osql.paramQUERY.Add("Sucursal", Sucursal)
                FolioDTE = osql.GetValorNoNull("AsignaFolio")
            Catch ex As Exception

            End Try
            Return FolioDTE
        End Function

    End Class

End Namespace
