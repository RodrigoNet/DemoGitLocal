Namespace be
    Public Class Usuarios
        Dim fono As String
        Public Property get_fono
            Get
                Return fono
            End Get
            Set(ByVal value)
                fono = value
            End Set
        End Property
        Public Sub New(ByVal fono As String)
            get_fono = fono
        End Sub

        Public Sub New()

        End Sub
    End Class

End Namespace
