
Public Class FormProveedores
    Private Sub FormProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Gestión de Proveedores"
        CargarProveedores()
    End Sub

    Private Sub CargarProveedores()
        Dim proveedores = ProveedorBL.ObtenerTodos()
        dgvProveedores.DataSource = proveedores
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim proveedor As New Proveedor()
        proveedor.Nombre = txtNombre.Text
        proveedor.Telefono = txtTelefono.Text
        proveedor.Email = txtEmail.Text

        ProveedorBL.Agregar(proveedor)
        CargarProveedores()
    End Sub
End Class
