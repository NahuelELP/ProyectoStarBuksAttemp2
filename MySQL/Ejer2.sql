CREATE TABLE user(
	id int not null auto_increment,
    name varchar(50) not null,
    edad int not null,
    email varchar(100) not null,
    primary key (id)
);

INSERT INTO user (name, edad , email) VALUES ("Nahuel",24 , "nahuellassos90@gmail.com");
INSERT INTO user (name, edad , email) VALUES ("Mati",17 , "nahuellassos90@gmail.com");
INSERT INTO user (name, edad , email) VALUES ("Tomas",21 , "nahuellassos90@gmail.com");
INSERT INTO user (name, edad , email) VALUES ("Lau",23 , "nahuellassos90@gmail.com");

select * FROM user;

UPDATE user SET email = "MatiLassos9@gmail.com" WHERE id = 2;
UPDATE user SET email = "Tomasss9@gmail.com" WHERE id = 3;
UPDATE user SET email = "Lauuuu9@gmail.com" WHERE id = 4;

select * FROM user limit 1;
select * FROM user WHERE edad > 15;
select * FROM user WHERE edad >= 17;
select * FROM user WHERE edad = 24 and email = "nahuellassos90@gmail.com";
select * FROM user WHERE edad = 24 or email = "Lauuuu9@gmail.com"; 
select * FROM user WHERE email != "nahuellassos90@gmail.com";
select * From user WHERE edad between 21 and 26;
select * from user where email like "%gmail%";
select * from user where email like "%gmail.com";

select * from user order by edad asc;
select * from user order by edad desc;
--            as--> (nombre dado)
select max(edad)as mayor from user;
select min(edad)as menor from user;

select id, name as nombres from user;

