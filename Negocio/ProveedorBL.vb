Imports InventarioVBNet.Datos
Imports InventarioVBNet.Entidades

Public Class ProveedorBL
    Public Shared Function ObtenerTodos() As DataTable
        Return ProveedorDAL.ObtenerTodos()
    End Function

    Public Shared Sub Agregar(proveedor As Proveedor)
        If String.IsNullOrWhiteSpace(proveedor.Nombre) Then
            Throw New Exception("El nombre del proveedor es obligatorio.")
        End If
        ProveedorDAL.Insertar(proveedor)
    End Sub

    Public Shared Sub Actualizar(proveedor As Proveedor)
        ProveedorDAL.Actualizar(proveedor)
    End Sub

    Public Shared Sub Eliminar(idProveedor As Integer)
        ProveedorDAL.Eliminar(idProveedor)
    End Sub
End Class
