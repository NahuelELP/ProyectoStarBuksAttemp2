Create database db_usuario 
GO
USE db_usuario
go
Create table Usuario(
id int primary key identity,
nombre varchar(50) not null,
apellido varchar(50) not null,
email varchar(100) not null,
username varchar(100),
fecha_creacion DATETIME
)
go

INSERT INTO Usuario ([nombre],[apellido],[email],[username],[fecha_creacion])
VALUES 
('Nahuel','perez','nahuellassos@gmail.com','nahuperez',GETDATE()),
('Lucas','Gomez','lucasgomez@gmail.com','lugomez',GETDATE()),
('Martin','Lopez','martinlopez@gmail.com','marlopez',GETDATE()),
('Santiago','Fernandez','santiagofernandez@gmail.com','sanfer',GETDATE()),
('Tomas','Rodriguez','tomasrodriguez@gmail.com','tomrodriguez',GETDATE()),
('Facundo','Martinez','facundomartinez@gmail.com','facumar',GETDATE()),
('Nicolas','Sanchez','nicolassanchez@gmail.com','nicosan',GETDATE()),
('Agustin','Diaz','agustindia@gmail.com','agusdiaz',GETDATE()),
('Franco','Torres','francotorres@gmail.com','frantor',GETDATE()),
('Matias','Ruiz','matiasruiz@gmail.com','matruiz',GETDATE()),
('Ignacio','Castro','ignaciocastro@gmail.com','ignacastro',GETDATE())
