-- Tabla de Clientes
CREATE TABLE Clientes (
    id_cliente INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    direccion NVARCHAR(200),
    telefono NVARCHAR(15)
);


-- Tabla de Productos
CREATE TABLE Productos (
    id_producto INT PRIMARY KEY IDENTITY(1,1),
    nombre NVARCHAR(100) NOT NULL,
    descripcion NVARCHAR(200),
    precio DECIMAL(10,2) NOT NULL,
    stock INT NOT NULL
);


-- Tabla de Ventas (relaciona clientes con productos)
CREATE TABLE Ventas (
    id_venta INT PRIMARY KEY IDENTITY(1,1),
    id_cliente INT NOT NULL,
    id_producto INT NOT NULL,
    cantidad INT NOT NULL,
    fecha_venta DATE NOT NULL DEFAULT GETDATE(),

    -- Claves foráneas
    FOREIGN KEY (id_cliente) REFERENCES Clientes(id_cliente),
    FOREIGN KEY (id_producto) REFERENCES Productos(id_producto)
);

INSERT INTO Clientes (nombre, direccion, telefono) VALUES 
('Ana Gómez', 'Av. Duarte 123', '809-123-0001'),
('Carlos Pérez', 'Calle 5 #45', '809-123-0002'),
('Luis Martínez', 'Calle A #10', '809-123-0003'),
('Sofía Rodríguez', 'Av. México 456', '809-123-0004'),
('Juan Ramírez', 'Calle Real 88', '809-123-0005'),
('Marta López', 'Villa Mella 17', '809-123-0006'),
('Pedro Castillo', 'Zona Colonial', '809-123-0007'),
('Lucía Vargas', 'Ensanche Piantini', '809-123-0008'),
('David Peña', 'San Isidro 9', '809-123-0009'),
('Karla Jiménez', 'Calle Jacaranda 33', '809-123-0010'),
('Miguel Torres', 'Av. Luperón 78', '809-123-0011'),
('Patricia Figueroa', 'Calle Los Robles', '809-123-0012'),
('José Guzmán', 'Av. Sarasota', '809-123-0013'),
('Diana Rivas', 'La Julia', '809-123-0014'),
('Héctor Sánchez', 'Los Alcarrizos', '809-123-0015'),
('Mariana Díaz', 'Calle 8 Esquina 3', '809-123-0016'),
('Roberto Núñez', 'Gascue', '809-123-0017'),
('Daniela Herrera', 'Av. Winston Churchill', '809-123-0018'),
('Andrés Méndez', 'Calle Sol 21', '809-123-0019'),
('Natalia Batista', 'Zona Universitaria', '809-123-0020');

INSERT INTO Productos (nombre, descripcion, precio, stock) VALUES 
('Paracetamol 500mg', 'Caja de 20 tabletas', 95.00, 100),
('Ibuprofeno 400mg', 'Caja de 30 tabletas', 120.00, 150),
('Omeprazol 20mg', 'Caja de 14 cápsulas', 135.00, 200),
('Loratadina 10mg', 'Caja de 10 tabletas', 85.00, 180),
('Amoxicilina 500mg', 'Caja de 21 cápsulas', 230.00, 90),
('Vitamina C 1000mg', 'Frasco de 60 tabletas', 150.00, 50),
('Acetaminofén 500mg', 'Caja de 16 tabletas', 80.00, 75),
('Antigripal Forte', 'Caja de 12 tabletas', 95.00, 60),
('Jarabe para la tos', 'Botella de 120ml', 145.00, 70),
('Insulina Regular', 'Frasco de 10ml', 520.00, 30),
('Tiras reactivas', 'Caja de 50 tiras', 450.00, 40),
('Gasa estéril', 'Paquete de 100 unidades', 70.00, 100),
('Alcohol 70%', 'Botella de 500ml', 50.00, 150),
('Termómetro digital', 'Unidad', 250.00, 20),
('Aspirina 100mg', 'Caja de 30 tabletas', 110.00, 60),
('Ranitidina 150mg', 'Caja de 20 tabletas', 120.00, 40),
('Clorfenamina', 'Caja de 12 tabletas', 90.00, 85),
('Salbutamol Inhalador', 'Inhalador', 320.00, 25),
('Pomada antibiótica', 'Tubo de 15g', 180.00, 45),
('Multivitamínico', 'Frasco de 30 cápsulas', 200.00, 50),
('Gotas para los ojos', 'Frasco de 15ml', 90.00, 55),
('Laxante', 'Caja de 10 tabletas', 75.00, 65),
('Anticonceptivo oral', 'Caja de 28 tabletas', 300.00, 70),
('Crema para hongos', 'Tubo de 30g', 140.00, 35),
('Enjuague bucal', 'Botella de 500ml', 130.00, 80),
('Pañales adultos', 'Paquete de 10', 280.00, 40),
('Toallas húmedas', 'Paquete de 80', 95.00, 60),
('Guantes médicos', 'Caja de 100', 190.00, 90),
('Mascarillas KN95', 'Paquete de 10', 210.00, 100),
('Suero oral', 'Frasco de 330ml', 45.00, 110);


INSERT INTO Ventas (id_cliente, id_producto, cantidad) VALUES 
(1, 3, 2),
(2, 5, 1),
(3, 7, 3),
(4, 2, 2),
(5, 10, 1),
(6, 8, 1),
(7, 6, 2),
(8, 1, 1),
(9, 15, 2),
(10, 4, 3),
(11, 20, 1),
(12, 14, 1),
(13, 12, 4),
(14, 11, 1),
(15, 25, 2),
(16, 17, 1),
(17, 9, 2),
(18, 13, 3),
(19, 18, 1),
(20, 19, 1),
(1, 21, 2),
(2, 22, 1),
(3, 23, 1),
(4, 24, 2),
(5, 26, 2),
(6, 27, 3),
(7, 28, 1),
(8, 29, 2),
(9, 30, 1),
(10, 16, 2);

select * from Clientes;