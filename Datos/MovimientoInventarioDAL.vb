Imports System.Data.SqlClient
Imports InventarioVBNet.Entidades

Public Class MovimientoInventarioDAL
    Public Shared Function ObtenerHistorial() As DataTable
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("SELECT * FROM MovimientosInventario ORDER BY Fecha DESC", conexion)
            Dim adaptador As New SqlDataAdapter(comando)
            Dim tabla As New DataTable()
            adaptador.Fill(tabla)
            Return tabla
        End Using
    End Function

    Public Shared Sub Insertar(movimiento As MovimientoInventario)
        Using conexion = Conexion.ObtenerConexion()
            Dim comando As New SqlCommand("INSERT INTO MovimientosInventario (IdProducto, Tipo, Cantidad, Fecha, Detalle) VALUES (@IdProducto, @Tipo, @Cantidad, @Fecha, @Detalle)", conexion)
            comando.Parameters.AddWithValue("@IdProducto", movimiento.IdProducto)
            comando.Parameters.AddWithValue("@Tipo", movimiento.Tipo)
            comando.Parameters.AddWithValue("@Cantidad", movimiento.Cantidad)
            comando.Parameters.AddWithValue("@Fecha", movimiento.Fecha)
            comando.Parameters.AddWithValue("@Detalle", movimiento.Detalle)
            comando.ExecuteNonQuery()
        End Using
    End Sub
End Class

