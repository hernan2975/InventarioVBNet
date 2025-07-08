-- Crear base de datos
CREATE DATABASE InventarioDB;
GO
USE InventarioDB;
GO

-- Tabla de Categorías
CREATE TABLE Categorias (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL
);

-- Tabla de Proveedores
CREATE TABLE Proveedores (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Telefono NVARCHAR(50),
    Email NVARCHAR(100)
);

-- Tabla de Productos
CREATE TABLE Productos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nombre NVARCHAR(100) NOT NULL,
    Stock INT NOT NULL,
    CategoriaId INT FOREIGN KEY REFERENCES Categorias(Id),
    ProveedorId INT FOREIGN KEY REFERENCES Proveedores(Id)
);

-- Tabla de Movimientos de Inventario
CREATE TABLE MovimientosInventario (
    Id INT PRIMARY KEY IDENTITY(1,1),
    IdProducto INT FOREIGN KEY REFERENCES Productos(Id),
    Tipo NVARCHAR(20), -- Entrada o Salida
    Cantidad INT NOT NULL,
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Detalle NVARCHAR(255)
);

