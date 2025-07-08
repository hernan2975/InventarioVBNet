# 🧾 InventarioVBNet

Sistema de gestión de inventario para pequeños comercios, desarrollado en **Visual Basic .NET** con arquitectura en capas y base de datos **SQL Server LocalDB**.

---

## 🚀 Características principales

- Gestión de productos con control de stock mínimo
- ABM de categorías y proveedores
- Registro de entradas y salidas de inventario
- Reportes exportables en PDF o Excel
- Interfaz amigable con Windows Forms

---

## 🛠️ Tecnologías utilizadas

- Visual Basic .NET (.NET Framework)
- SQL Server LocalDB
- Windows Forms
- Arquitectura en capas (Presentación, Negocio, Datos)

---

## 📁 Estructura del proyecto

InventarioVBNet/
│
├── Presentacion/               # Capa de presentación (Windows Forms)
│   ├── FormPrincipal.vb
│   ├── FormProductos.vb
│   ├── FormProveedores.vb
│   └── ...
│
├── Negocio/                    # Capa de lógica de negocio
│   ├── ProductoBL.vb
│   ├── ProveedorBL.vb
│   └── MovimientoInventarioBL.vb
│
├── Datos/                      # Capa de acceso a datos
│   ├── Conexion.vb
│   ├── ProductoDAL.vb
│   ├── ProveedorDAL.vb
│   └── MovimientoInventarioDAL.vb
│
├── Entidades/                 # Modelos de datos
│   ├── Producto.vb
│   ├── Proveedor.vb
│   └── MovimientoInventario.vb
│
├── Reportes/                  # Reportes PDF o Excel
│   └── ReporteStock.rdlc
│
├── BaseDeDatos/               # Script o backup de la DB
│   └── inventario_script.sql
│
├── Documentacion/             # Manual técnico y de usuario
│   ├── ManualUsuario.pdf
│   └── DocumentacionTecnica.pdf
│
├── InventarioVBNet.sln        # Solución de Visual Studio
└── README.md

---

## 📦 Instalación

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tuusuario/InventarioVBNet.git

2. Abrir InventarioVBNet.sln en Visual Studio

3. Restaurar la base de datos desde BaseDeDatos/inventario_script.sql

4. Compilar y ejecutar

📚 Documentación

Manual de Usuario
Documentación Técnica

🪪 Licencia
Este proyecto está bajo la licencia MIT. Ver LICENSE para más información.
