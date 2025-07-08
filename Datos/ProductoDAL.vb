
Imports System.Data.SqlClient
Imports InventarioVBNet.Entidades

Public Class ProductoDAL
    Public Shared Function ObtenerTodos() As DataTable
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("SELECT * FROM Productos", conexion)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        End Using
    End Function

    Public Shared Sub Insertar(producto As Producto)
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("INSERT INTO Productos (Nombre, Stock, CategoriaId) VALUES (@Nombre, @Stock, @CategoriaId)", conexion)
            comando.Parameters.AddWithValue("@Nombre", producto.Nombre)
            comando.Parameters.AddWithValue("@Stock", producto.Stock)
            comando.Parameters.AddWithValue("@CategoriaId", producto.CategoriaId)
            comando.ExecuteNonQuery()
        End Using
    End Sub

    Public Shared Sub ActualizarStock(idProducto As Integer, cantidad As Integer)
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("UPDATE Productos SET Stock = Stock + @Cantidad WHERE Id = @Id", conexion)
            comando.Parameters.AddWithValue("@Cantidad", cantidad)
            comando.Parameters.AddWithValue("@Id", idProducto)
            comando.ExecuteNonQuery()
        End Using
    End Sub
End Class
