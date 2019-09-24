Namespace be
    Public Class F_Pago
        Dim F_Pago As String
        Public Property get_F_Pago
            Get
                Return F_Pago
            End Get
            Set(ByVal value)
                F_Pago = value
            End Set
        End Property
        Public Sub New(ByVal F_Pago As String)
            get_F_Pago = F_Pago
        End Sub

        Public Sub New()

        End Sub
    End Class

End Namespace
