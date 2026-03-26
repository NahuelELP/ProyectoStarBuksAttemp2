CREATE TABLE Products(
id int not null auto_increment,
name varchar(50) not null,
created_by int not null,
primary key(id),
foreign key(created_by) references usuario(id)
);

rename table products to product;
alter table product add column marca varchar(50) not null;
insert into product(name, created_by, marca)
value
("iphone", 1, "apple"),
("ipad", 2, "apple"),
("watch",3, "apple"),
("macbook",1,"apple"),
("imac",2,"apple"),
("ipad mini",3,"apple");

SELECT * FROM product;

