create table usuarios(
	id int not null auto_increment,
    nombre varchar(50)not null,
    primary key(id)
);
create table pedidos(
	id int not null auto_increment,
    usuario_id int not null,
    total int not null,
    primary key(id),
    foreign key(usuario_id) references usuarios(id)
);

insert into usuarios(nombre)
value("Ana"),("Luis"),("Marta"),("Pedro");

insert into pedidos(usuario_id, total)
value(1, 50),(1, 70),(2, 30),(2, 20),(3, 200),(3, 150);

select * from usuarios;
select * from pedidos;

select u.nombre, count(p.id) as cantidad_pedidos, sum(p.total) as dinero_total
from usuarios u
inner join pedidos p
on u.id= p.usuario_id
group by u.nombre
having sum(p.total)> 100
 -- extra
 order by dinero_total desc;
 
 drop table pedidos;
 drop table usuarios;