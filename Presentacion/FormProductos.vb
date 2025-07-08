
Public Class FormProductos
    Private Sub FormProductos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestión de Productos"
        CargarProductos()
    End Sub

    Private Sub CargarProductos()
        ' Aquí iría la lógica para cargar productos desde la capa de negocio
        Dim productos = ProductoBL.ObtenerTodos()
        dgvProductos.DataSource = productos
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        Dim nuevoProducto As New Producto()
        nuevoProducto.Nombre = txtNombre.Text
        nuevoProducto.Stock = Convert.ToInt32(txtStock.Text)
        nuevoProducto.CategoriaId = Convert.ToInt32(cmbCategoria.SelectedValue)

        ProductoBL.Agregar(nuevoProducto)
        CargarProductos()
    End Sub
End Class
