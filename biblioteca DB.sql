create database biblioteca;
use biblioteca;

create table libro(
	id int auto_increment not null,
    nombre varchar(90),
    autor varchar(90),
    idioma varchar(25),
    ejemplares int not null,
    primary key(id)
);

create table socio(
	id int auto_increment not null,
    nombre varchar(20) not null,
    apellido varchar(25) not null,
    dni int not null unique,
    telefono int,
    direccion varchar(50),
    primary key(id)
);

create table reservacion(
	id int auto_increment not null,
    idLibro int,
    idSocio int,
    fechaSalida date not null,
    fechaDev date not null,
    primary key(id),
    foreign key(idLibro) references libro(id),
    foreign key(idSocio) references socio(id)
);

insert into socio(nombre,apellido,dni,telefono,direccion) values ('jose','perez',11111111,12345678,'guemes 386'),
('mario','gomez',223256667,76654901,'mitre 200'),
('maria','gutierres',23823632,11675589,'calle 15 271'),
('antonio','gonsalez',2412345678,1167553389,'calle 12 4385');

insert into libro(nombre,autor,idioma,ejemplares) values ('Aladdin','Ritchie y Vanessa Taylor','Español', 10),
('IT','Stephen King','Español', 12),
('El Señor de los Anillos: La Comunidad del Anillo','J.R.R. Tolkien','Español', 6),
('El Señor de los Anillos: La Comunidad del Anillo','J.R.R. Tolkien','Español', 6),
 ('El Señor de los Anillos: El retorno del rey','J.R.R. Tolkien','Español', 4),
('El Señor de los Anillos: Las dos torres','J.R.R. Tolkien','Español', 8);

select * from libro;

select * from socio;

delete from libro where id=2;

update libro set ejemplares = ejemplares-1 where id= 2;
