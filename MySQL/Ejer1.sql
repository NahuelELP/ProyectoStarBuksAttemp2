create database BaseMia;
show databases;
use basemia;
CREATE TABLE animales(
	id int,
    tipo varchar(255),
    estado varchar(255),
    PRIMARY KEY(id)
);

-- INSERT INTO animales(tipo, estado) VALUE ('chanchito', 'feliz');
-- modificar una tabla ya creada
alter table animales modify column id int auto_increment;

show create table animales;
-- como crear una tabla
CREATE TABLE `animales` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tipo` varchar(255) DEFAULT NULL,
  `estado` varchar(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
);

INSERT INTO animales(tipo, estado) VALUE ('chanchito', 'feliz');
INSERT INTO animales(tipo, estado) VALUE ('dragon', 'feliz');
INSERT INTO animales(tipo, estado) VALUE ('felipe', 'triste');

SELECT * FROM animales;
SELECT * FROM animales WHERE id= 1;
SELECT * FROM animales WHERE estado = 'feliz' AND tipo = 'chanchito';

UPDATE animales SET estado = 'feliz' WHERE id = 4;

SELECT * FROM animales;

DELETE FROM animales WHERE estado = 'feliz';

DELETE FROM animales WHERE id =1;

UPDATE animales SET estado = "triste" = "dragon";
-- error 1175 pasar si o si el id (posible catastrofe)


