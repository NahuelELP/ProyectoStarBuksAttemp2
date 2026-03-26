CREATE TABLE usuarios (
    id INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE productos (
    id INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    precio INT NOT NULL,
    PRIMARY KEY (id)
);

CREATE TABLE pedidos (
    id INT NOT NULL AUTO_INCREMENT,
    usuario_id INT NOT NULL,
    producto_id INT NOT NULL,
    cantidad INT NOT NULL,
    PRIMARY KEY (id),
    FOREIGN KEY (usuario_id) REFERENCES usuarios(id),
    FOREIGN KEY (producto_id) REFERENCES productos(id)
);

INSERT INTO usuarios (nombre)
VALUES ("Ana"), ("Luis"), ("Marta"), ("Pedro");

INSERT INTO productos (nombre, precio)
VALUES ("Café", 5), ("Té", 3), ("Sandwich", 8);

INSERT INTO pedidos (usuario_id, producto_id, cantidad)
VALUES 
(1, 1, 2),
(1, 2, 1),
(2, 3, 1),
(2, 3, 2),
(3, 1, 1);

SELECT * FROM usuarios;
SELECT * FROM productos;
SELECT * FROM pedidos;

select u.nombre, 
count(ped.cantidad) as cantidad_total_pedidos, 
coalesce(sum(ped.cantidad * pro.precio),0) as dinero_total_gastado
from usuarios u
left join pedidos ped
on u.id = ped.usuario_id
left join productos pro
on pro.id = ped.producto_id
group by u.nombre
having dinero_total_gastado > 5;