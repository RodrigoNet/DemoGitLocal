Namespace be

    Public Class Facturas
        Private rut As String
        Private tipoDTE As Integer
        Private CodigoProducto As String
        Private DescripcionProducto As String
        Private precioProducto As Integer
        Private cantidad As Integer
        Private UM As String
        Private TipoDescuento As String
        Private RazonDescuento As String
        Private folioDTE As Integer

        Public Property get_rut As String
            Get
                Return rut
            End Get
            Set(ByVal value As String)
                rut = value
            End Set
        End Property
        Public Property get_tipoDTE As Integer
            Get
                Return tipoDTE
            End Get
            Set(value As Integer)
                tipoDTE = value
            End Set
        End Property
        Public Property get_folioDTE As Integer
            Get
                Return folioDTE
            End Get
            Set(value As Integer)
                folioDTE = value
            End Set
        End Property
        Public Property get_CodigoProducto As String
            Get
                Return CodigoProducto
            End Get
            Set(ByVal value As String)
                CodigoProducto = value
            End Set
        End Property
        Public Property get_DescripcionProducto As String
            Get
                Return DescripcionProducto
            End Get
            Set(ByVal value As String)
                DescripcionProducto = value
            End Set
        End Property
        Public Property get_precioProducto As Integer
            Get
                Return precioProducto
            End Get
            Set(ByVal value As Integer)
                precioProducto = value
            End Set
        End Property
        Public Property get_cantidad As Integer
            Get
                Return cantidad
            End Get
            Set(ByVal value As Integer)
                cantidad = value
            End Set
        End Property
        Public Property get_UM As String
            Get
                Return UM
            End Get
            Set(ByVal value As String)
                UM = value
            End Set
        End Property
        Public Property get_TipoDescuento As String
            Get
                Return TipoDescuento
            End Get
            Set(ByVal value As String)
                TipoDescuento = value
            End Set
        End Property
        Public Property get_RazonDescuento As String
            Get
                Return RazonDescuento
            End Get
            Set(ByVal value As String)
                RazonDescuento = value
            End Set
        End Property
    End Class

End Namespace