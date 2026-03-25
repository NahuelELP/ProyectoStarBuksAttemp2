create table usuarios(
	id int not null auto_increment,
    nombre varchar(50) not null,
    primary key(id)
);
create table productos(
	id int not null auto_increment,
    nombre varchar(50) not null,
    precio int not null,
    primary key(id)
);
create table pedidos(
	id int not null auto_increment,
    usuario_id int not null,
    producto_id int not null,
    primary key(id),
    foreign key(usuario_id) references usuarios(id),
    foreign key(producto_id) references productos(id)
);

insert into usuarios(nombre)
values("Ana"),("Luis"),("Marta"),("Pedro");

insert into productos(nombre, precio)
values("cafe",5),("Te",3),("sandwich",8);

insert into pedidos(usuario_id, producto_id)
values(1,1),(1,3),(2,2),(2,2),(3,3),(3,3);

select * from usuarios;
select * from productos;
select * from pedidos;

SELECT u.nombre, COUNT(ped.id) AS cantidad_pedidos, SUM(pro.precio) AS dinero_total_gastado
FROM usuarios u
INNER JOIN pedidos ped
ON u.id = ped.usuario_id
INNER JOIN productos pro
ON ped.producto_id = pro.id
GROUP BY u.nombre
HAVING COUNT(ped.id) >= 2;

drop table usuarios;
drop table pedidos;
drop table productos;
