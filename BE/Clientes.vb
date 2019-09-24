Namespace be
    Public Class Clientes
        Dim rut As String
        Dim CodCliente As String
        Dim razonsocial As String
        Dim giro As String
        Dim direccion As String
        Dim comuna As String
        Dim ciudad As String
        Dim emailpdf As String
        Dim emailxml As String
        Dim fono As String

        Public Property get_rut
            Get
                Return rut
            End Get
            Set(ByVal value)
                rut = value
            End Set
        End Property
        Public Property get_CodCliente
            Get
                Return CodCliente
            End Get
            Set(ByVal value)
                CodCliente = value
            End Set
        End Property
        Public Property get_razonsocial
            Get
                Return razonsocial
            End Get
            Set(ByVal value)
                razonsocial = value
            End Set
        End Property
        Public Property get_giro
            Get
                Return giro
            End Get
            Set(ByVal value)
                giro = value
            End Set
        End Property
        Public Property get_direccion
            Get
                Return direccion
            End Get
            Set(ByVal value)
                direccion = value
            End Set
        End Property
        Public Property get_comuna
            Get
                Return comuna
            End Get
            Set(ByVal value)
                comuna = value
            End Set
        End Property
        Public Property get_ciudad
            Get
                Return ciudad
            End Get
            Set(ByVal value)
                ciudad = value
            End Set
        End Property
        Public Property get_emailpdf
            Get
                Return emailpdf
            End Get
            Set(ByVal value)
                emailpdf = value
            End Set
        End Property
        Public Property get_emailxml
            Get
                Return emailxml
            End Get
            Set(ByVal value)
                emailxml = value
            End Set
        End Property
        Public Property get_fono
            Get
                Return fono
            End Get
            Set(ByVal value)
                fono = value
            End Set
        End Property
        Public Sub New(ByVal rut As String, ByVal CodCliente As String, ByVal razonsocial As String, ByVal giro As String, ByVal direccion As String, ByVal comuna As String, ByVal ciudad As String, ByVal emailpdf As String, ByVal emailxml As String, ByVal fono As String)
            get_rut = rut
            get_CodCliente = CodCliente
            get_razonsocial = razonsocial
            get_giro = giro
            get_direccion = direccion
            get_comuna = comuna
            get_ciudad = ciudad
            get_emailpdf = emailpdf
            get_emailxml = emailxml
            get_fono = fono
        End Sub

        Public Sub New()

        End Sub

    End Class
End Namespace