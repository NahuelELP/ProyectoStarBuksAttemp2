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
    cantidad int not null,
    primary key(id),
    foreign key(usuario_id) references usuarios(id),
    foreign key(producto_id) references productos(id)
);

insert into usuarios(nombre)
values("Ana"),("Luis"),("Marta"),("Pedro");

insert into productos(nombre, precio)
values("Cafe",5),("Te",3),("Sandwich",8);

insert into pedidos(usuario_id,producto_id,cantidad)
values(1,1,2),(1,3,1),(2,2,3),(2,2,1),(3,3,2),(3,1,1);

select * from pedidos;

select u.nombre, pro.nombre, 
SUM(ped.cantidad) as cantidad_total_comprada, 
SUM(ped.cantidad * pro.precio) as dinero_total_gastado
from usuarios u
inner join pedidos ped
on u.id = ped.usuario_id
inner join productos pro
on pro.id = ped.producto_id
group by u.nombre, pro.nombre
having cantidad_total_comprada >2;

select * from pedidos;
select * from productos;
select * from usuarios;