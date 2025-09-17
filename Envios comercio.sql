use master
go
drop database Envios_comercio
go

CREATE DATABASE Envios_comercio
GO
USE Envios_comercio
GO

-- Tabla Producto
CREATE TABLE Productos (
    id INT IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    precio DECIMAL(10,2) NOT NULL
	CONSTRAINT PK_Producto PRIMARY KEY (id)
);

-- Tabla Envio
CREATE TABLE Envios (
    id INT IDENTITY(1,1),
    fecha DATE NOT NULL,
    dniCliente CHAR(8) NOT NULL,
    direccion NVARCHAR(200) NOT NULL,
    palabraSecreta NVARCHAR(50),
    estado NVARCHAR(20) NOT NULL
	CONSTRAINT PK_Envios PRIMARY KEY (id)
);

-- Tabla DetalleEnvio
CREATE TABLE DetallesEnvio (
    id INT IDENTITY(1,1),
    idEnvio INT NOT NULL,
    idProducto INT NOT NULL,
    cantidad INT NOT NULL,
    comentario NVARCHAR(200),
	CONSTRAINT PK_DetallesEnvio PRIMARY KEY (id),
    CONSTRAINT FK_DetallesEnvio_Envio FOREIGN KEY (idEnvio) 
        REFERENCES Envios(id),
    CONSTRAINT FK_DetalleEnvio_Producto FOREIGN KEY (idProducto) 
        REFERENCES Productos(id)
);

INSERT INTO Productos (nombre, precio) VALUES
('Laptop', 850000.00),
('Mouse', 8500.50),
('Teclado Mecánico', 25000.00),
('Monitor 24"', 120000.00),
('Impresora', 95000.00),
('Silla Gamer', 180000.00),
('Auriculares', 30000.00),
('Webcam HD', 15000.00),
('Parlantes Bluetooth', 22000.00),
('Disco SSD 1TB', 140000.00);

INSERT INTO Envios (fecha, dniCliente, direccion, palabraSecreta, estado) VALUES
('2025-09-01','40111222','Av. Siempre Viva 742','clave1','Pendiente'),
('2025-09-02','40222333','Calle Falsa 123','clave2','En camino'),
('2025-09-02','40333444','Av. Libertador 456','clave3','Entregado'),
('2025-09-03','40444555','San Martín 789','clave4','Pendiente'),
('2025-09-03','40555666','Belgrano 321','clave5','Cancelado'),
('2025-09-04','40666777','Mitre 654','clave6','Pendiente'),
('2025-09-05','40777888','Rivadavia 147','clave7','En camino'),
('2025-09-05','40888999','Pueyrredón 258','clave8','Entregado'),
('2025-09-06','40999000','Alsina 369','clave9','Pendiente'),
('2025-09-07','40100111','Cabildo 741','clave10','Pendiente'),
('2025-09-07','40211222','Córdoba 951','clave11','Entregado'),
('2025-09-08','40322333','Santa Fe 159','clave12','Pendiente'),
('2025-09-08','40433444','Callao 753','clave13','En camino'),
('2025-09-09','40544555','Entre Ríos 357','clave14','Pendiente'),
('2025-09-09','40655666','Corrientes 159','clave15','Cancelado'),
('2025-09-10','40766777','Urquiza 753','clave16','Pendiente'),
('2025-09-10','40877888','Dorrego 951','clave17','Entregado'),
('2025-09-11','40988999','Rosales 147','clave18','Pendiente'),
('2025-09-11','40199000','Alem 258','clave19','En camino'),
('2025-09-12','40200111','Rawson 369','clave20','Pendiente');

INSERT INTO DetallesEnvio (idEnvio, idProducto, cantidad, comentario) VALUES
(1, 1, 1, 'Entrega rápida'),
(1, 2, 2, 'Incluye pilas'),
(2, 3, 1, 'Color negro'),
(2, 5, 1, 'Con garantía'),
(3, 4, 2, 'Revisar antes de entregar'),
(3, 6, 1, 'Edición limitada'),
(4, 7, 3, 'Empaque seguro'),
(4, 9, 1, 'Cliente exigente'),
(5, 8, 2, 'Frágil'),
(5, 10, 1, 'Alta prioridad'),
(6, 1, 1, 'Entrega sábado'),
(6, 3, 2, 'Incluye cable extra'),
(7, 2, 1, 'Entrega en oficina'),
(7, 6, 1, 'Color rojo'),
(8, 4, 1, 'Garantía extendida'),
(8, 9, 2, 'En caja cerrada'),
(9, 7, 1, 'Empaque con burbujas'),
(9, 5, 2, 'Entrega en mano'),
(10, 8, 1, 'Entrega de tarde'),
(10, 1, 1, 'Con factura A'),
(11, 10, 2, 'Urgente'),
(11, 2, 1, 'Entrega a vecino'),
(12, 3, 1, 'Color azul'),
(12, 4, 2, 'Revisar pantalla'),
(13, 6, 1, 'Cliente vip'),
(13, 7, 2, 'Frágil'),
(14, 9, 1, 'Incluir manual'),
(14, 5, 1, 'Entrega lunes'),
(15, 1, 1, 'Entrega urgente'),
(15, 8, 2, 'Frágil'),
(16, 2, 1, 'Entrega normal'),
(16, 10, 1, 'Alta prioridad'),
(17, 3, 2, 'Revisar antes de entregar'),
(17, 4, 1, 'Empaque seguro'),
(18, 5, 2, 'Cliente frecuente'),
(18, 6, 1, 'Entrega nocturna'),
(19, 7, 3, 'Empaque reforzado'),
(19, 9, 2, 'Entrega al portero'),
(20, 8, 1, 'Entrega en domicilio'),
(20, 10, 1, 'Incluye garantía'),
(2, 1, 1, 'Extra pedido'),
(4, 2, 2, 'Adicional'),
(6, 3, 1, 'Repuesto'),
(8, 5, 1, 'Reposición'),
(10, 7, 1, 'Extra stock'),
(12, 9, 1, 'Entrega rápida'),
(14, 10, 1, 'Cliente preferente'),
(16, 4, 1, 'Segunda unidad'),
(18, 2, 2, 'Reposición urgente'),
(20, 6, 1, 'Pedido express');
