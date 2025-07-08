Imports System.Data.SqlClient

Public Class Conexion
    Private Shared ReadOnly cadenaConexion As String = "Server=(localdb)\MSSQLLocalDB;Database=InventarioDB;Integrated Security=True"

    Public Shared Function ObtenerConexion() As SqlConnection
        Dim conexion As New SqlConnection(cadenaConexion)
        conexion.Open()
        Return conexion
    End Function
End Class

