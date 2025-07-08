
Imports System.Data.SqlClient
Imports InventarioVBNet.Entidades

Public Class ProveedorDAL
    Public Shared Function ObtenerTodos() As DataTable
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("SELECT * FROM Proveedores", conexion)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        End Using
    End Function

    Public Shared Sub Insertar(proveedor As Proveedor)
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("INSERT INTO Proveedores (Nombre, Telefono, Email) VALUES (@Nombre, @Telefono, @Email)", conexion)
            comando.Parameters.AddWithValue("@Nombre", proveedor.Nombre)
            comando.Parameters.AddWithValue("@Telefono", proveedor.Telefono)
            comando.Parameters.AddWithValue("@Email", proveedor.Email)
            comando.ExecuteNonQuery()
        End Using
    End Sub
End Class
