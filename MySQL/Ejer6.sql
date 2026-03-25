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
    foreign key(usuario_id)references usuarios(id),
    foreign key(producto_id)references productos(id)
);

insert into usuarios(nombre)
values("Ana"),("Luis"),("Marta"),("Pedro");

insert into productos(nombre, precio)
values("cafe",5),("Te",3),("sandwich",8);

insert into pedidos(usuario_id, producto_id, cantidad)
values(1,1,2),(1,3,1),(2,2,3),(2,2,1),(3,3,2),(3,1,1);

select*from pedidos;

drop table pedidos;
drop table productos;
drop table usuarios;