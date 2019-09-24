Namespace be
    Public Class Productos
        Dim CodProducto As String
        Dim Descripcion As String
        Dim InfoAdic As String
        Dim UM As String
        Dim exento As Boolean
        Dim CodImpuestoAdic1 As String
        Dim CodImpuestoAdic2 As String
        Dim TasaImpAdic1 As Integer
        Dim TasaImpAdic2 As String
        Dim Precio As Integer
        Dim CodigoBarra As String
        Dim CodigoProveedor As String
        Dim CodigoExtra1 As String
        Dim CodigoExtra2 As String

        Public Property get_CodProducto
            Get
                Return CodProducto
            End Get
            Set(ByVal value)
                CodProducto = value
            End Set
        End Property
        Public Property get_Descripcion
            Get
                Return Descripcion
            End Get
            Set(ByVal value)
                Descripcion = value
            End Set
        End Property
        Public Property get_InfoAdic
            Get
                Return InfoAdic
            End Get
            Set(ByVal value)
                InfoAdic = value
            End Set
        End Property
        Public Property get_UM
            Get
                Return UM
            End Get
            Set(ByVal value)
                UM = value
            End Set
        End Property
        Public Property get_exento
            Get
                Return exento
            End Get
            Set(ByVal value)
                exento = value
            End Set
        End Property
        Public Property get_CodImpuestoAdic1
            Get
                Return CodImpuestoAdic1
            End Get
            Set(ByVal value)
                CodImpuestoAdic1 = value
            End Set
        End Property
        Public Property get_CodImpuestoAdic2
            Get
                Return CodImpuestoAdic2
            End Get
            Set(ByVal value)
                CodImpuestoAdic2 = value
            End Set
        End Property
        Public Property get_TasaImpAdic1
            Get
                Return TasaImpAdic1
            End Get
            Set(ByVal value)
                TasaImpAdic1 = value
            End Set
        End Property
        Public Property get_TasaImpAdic2
            Get
                Return TasaImpAdic2
            End Get
            Set(ByVal value)
                TasaImpAdic2 = value
            End Set
        End Property
        Public Property get_Precio
            Get
                Return Precio
            End Get
            Set(ByVal value)
                Precio = value
            End Set
        End Property
        Public Property get_CodigoBarra
            Get
                Return CodigoBarra
            End Get
            Set(ByVal value)
                CodigoBarra = value
            End Set
        End Property
        Public Property get_CodigoProveedor
            Get
                Return CodigoProveedor
            End Get
            Set(ByVal value)
                CodigoProveedor = value
            End Set
        End Property
        Public Property get_CodigoExtra1
            Get
                Return CodigoExtra1
            End Get
            Set(ByVal value)
                CodigoExtra1 = value
            End Set
        End Property
        Public Property get_CodigoExtra2
            Get
                Return CodigoExtra2
            End Get
            Set(ByVal value)
                CodigoExtra2 = value
            End Set
        End Property

        Public Sub New(ByVal CodProducto As String)
            get_CodProducto = CodProducto
            get_Descripcion = Descripcion
            get_InfoAdic = InfoAdic
            get_UM = UM
            get_exento = exento
            get_CodImpuestoAdic1 = CodImpuestoAdic1
            get_CodImpuestoAdic2 = CodImpuestoAdic2
            get_TasaImpAdic1 = TasaImpAdic1
            get_TasaImpAdic2 = TasaImpAdic2
            get_Precio = Precio
            get_CodigoBarra = CodigoBarra
            get_CodigoProveedor = CodigoProveedor
            get_CodigoExtra1 = CodigoExtra1
            get_CodigoExtra2 = CodigoExtra2
        End Sub

        Public Sub New()

        End Sub

    End Class

End Namespace