Imports InventarioVBNet.Datos
Imports InventarioVBNet.Entidades

Public Class ProductoBL
    Public Shared Function ObtenerTodos() As DataTable
        Return ProductoDAL.ObtenerTodos()
    End Function

    Public Shared Sub Agregar(producto As Producto)
        If producto.Stock < 0 Then
            Throw New Exception("El stock no puede ser negativo.")
        End If
        ProductoDAL.Insertar(producto)
    End Sub

    Public Shared Sub Actualizar(producto As Producto)
        ProductoDAL.Actualizar(producto)
    End Sub

    Public Shared Sub Eliminar(idProducto As Integer)
        ProductoDAL.Eliminar(idProducto)
    End Sub
End Class
