create database proyecto;
use proyecto;

create table usuarios (cedula int primary key, nombre varchar(50), apellido varchar(50) , email varchar(60), contraseña varchar(100));
select * from usuarios;

create table calendario (ID_tarea int primary key auto_increment, tarea varchar(50), fecha date);
select * from calendario;
