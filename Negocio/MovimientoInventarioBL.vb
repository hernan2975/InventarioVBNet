Imports InventarioVBNet.Datos
Imports InventarioVBNet.Entidades

Public Class MovimientoInventarioBL
    Public Shared Function ObtenerHistorial() As DataTable
        Return MovimientoInventarioDAL.ObtenerHistorial()
    End Function

    Public Shared Sub RegistrarEntrada(movimiento As MovimientoInventario)
        movimiento.Tipo = "Entrada"
        MovimientoInventarioDAL.Insertar(movimiento)
        ProductoDAL.ActualizarStock(movimiento.IdProducto, movimiento.Cantidad)
    End Sub

    Public Shared Sub RegistrarSalida(movimiento As MovimientoInventario)
        movimiento.Tipo = "Salida"
        MovimientoInventarioDAL.Insertar(movimiento)
        ProductoDAL.ActualizarStock(movimiento.IdProducto, -movimiento.Cantidad)
    End Sub
End Class
