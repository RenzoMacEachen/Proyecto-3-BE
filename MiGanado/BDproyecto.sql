create database proyecto;
use proyecto;

create user administrador identified by 'administrador';
grant insert, delete, update, select on * to administrador;

create user contable identified by 'contable';
grant insert, update, select on compra to contable;
grant insert, update, select on venta to contable;

create user supervisor identified by 'supervisor';
grant select on * to supervisor;

create user empleado identified by 'empleado';
grant select, insert, update on movimientos to empleado;
grant select on animal to empleado;
grant select on potrero to empleado;
grant select on categoria to empleado;


create table usuarios (nombre varchar(50), 
apellido varchar(50), 
cedula int primary key, 
email varchar(60), 
contraseña varchar(256));

create table animal (ID_animal int primary key auto_increment, 
fecha_nacimiento date, 
ID_categoria int, foreign key (ID_categoria) references categoria(ID_categoria),
ID_potrero int, foreign key (ID_potrero) references potrero(ID_potrero),
guia_compra varchar(30), foreign key (guia_compra) references compra(guia_compra),
guia_venta varchar(30), foreign key (guia_venta) references venta(guia_venta));

create table potrero(ID_potrero int primary key auto_increment, 
nombre varchar(30), 
hectareas int);

create table categoria(ID_categoria int primary key auto_increment,
nombre varchar(70),
unidad_ganadera decimal(5,2),
tipo varchar(40));

-- Agregar todas las categorias (Fijas)
-- Bovino
insert into categoria(nombre, unidad_ganadera, tipo) values ("Toro", 1.2, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría(primavera ternero menor de 2 meses)", 1.1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría(primavera ternero de 3 a 6 meses)", 1.3, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría(otoño desterneradas)", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de cría invierno(preñadas)", 0.8, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vacas de invernada", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vaquillonas +2 años", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Vaquillonas 1-2 años", 0.7, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Novillos +3 años ", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Novillos 2-3 años", 1, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Novillos 1-2 años", 0.7, "Bovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Terneros/as", 0.4, "Bovinos");
-- Ovinos
insert into categoria(nombre, unidad_ganadera, tipo) values ("Carneros", 0.17, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Ovejas de cría", 0.17, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Ovejas de cría con cordero al pie", 0.18, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Capones y borregos de 2 a 4 dientes", 0.15, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Borregas 2-4 dientes", 0.15, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Borregos/as diente de leche", 0.11, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Ovejas de refugo", 0.15, "Ovinos");
insert into categoria(nombre, unidad_ganadera, tipo) values ("Corderos/as menos de 20kg", 0.08, "Ovinos");
-- Equinos
insert into categoria(nombre, unidad_ganadera, tipo) values ("Equinos adultos", 1.2, "Equinos");

create table compra(guia_compra varchar(30) primary key, 
fecha date, 
origen varchar(40));

create table venta(guia_venta varchar(30) primary key,
fecha date,
destino varchar(40));

create table movimientos ( 
ID_animal int, foreign key (ID_animal) references animal(ID_animal),
ID_potreroOrigen int, foreign key (ID_potreroOrigen) references potrero(ID_potrero),
ID_potreroDestino int, foreign key (ID_potreroDestino) references potrero(ID_potrero),
fecha date);

create table calendario (ID_tarea int primary key auto_increment, tarea varchar(50), fecha date);
select * from calendario;

-- CONSULTAS
-- ordenar por id
SELECT p.nombre AS NombrePotrero, p.hectareas AS Hectareas, COUNT(a.ID_animal) AS CantidadAnimales
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
GROUP BY p.ID_potrero;

-- ordenar por hectareas
SELECT p.nombre AS NombrePotrero, p.hectareas AS Hectareas, COUNT(a.ID_animal) AS CantidadAnimales
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
GROUP BY p.ID_potrero ORDER BY p.hectareas DESC;

-- Ver potreros
-- Se ven todos los potreros junto a la cantidad de aniamles ingresados en ese potrero, sus hectáreas y el calculo ya hecho de la unidad ganadera.
SELECT p.nombre AS Nombre, 
p.hectareas AS Hectáreas, 
COUNT(a.ID_animal) AS Animales, 
CAST(ROUND(COALESCE(SUM(c.unidad_ganadera), 0) / p.hectareas, 3) AS DECIMAL(10, 3)) AS 'Unidad Ganadera'
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
LEFT JOIN categoria c ON a.ID_categoria = c.ID_categoria
GROUP BY p.ID_potrero;
-- Ver movimientos
-- En esta consulta se ven todos los movimientos agrupados por categoria, potrero del que venian, potrero al que fueron y la fecha.
SELECT c.nombre AS Categoría,
pOrigen.nombre AS 'Potrero Origen',
pDestino.nombre AS 'Potrero Destino',
COUNT(*) AS Cantidad,
fecha AS Fecha
FROM movimientos m
JOIN animal a ON m.ID_animal = a.ID_animal
JOIN potrero pOrigen ON m.ID_potreroOrigen = pOrigen.ID_potrero
JOIN potrero pDestino ON m.ID_potreroDestino = pDestino.ID_potrero
JOIN categoria c ON a.ID_categoria = c.ID_categoria
GROUP BY c.nombre, pOrigen.nombre, pDestino.nombre, m.fecha;
-- Ver animales
-- En esta consulta se muestran todos los animales ingresados, agrupados por categoria y potrero. Junto a la fecha de nacimiento y la cantidad encontrada.
 SELECT c.nombre AS Categoría, p.nombre AS Potrero, a.fecha_nacimiento AS Nacimiento, COUNT(a.ID_animal) AS Cantidad
 FROM animal a
 JOIN categoria c on a.ID_categoria = c.ID_categoria
 JOIN potrero p on a.ID_potrero = p.ID_potrero
 GROUP BY a.ID_categoria, a.ID_potrero;
 

-- ordenar por cantidad animales
SELECT p.nombre AS NombrePotrero, p.hectareas AS Hectareas, COUNT(a.ID_animal) AS CantidadAnimales
FROM potrero p
LEFT JOIN animal a ON p.ID_potrero = a.ID_potrero
GROUP BY p.ID_potrero ORDER BY CantidadAnimales DESC;

SELECT 
    C.nombre AS categoria,
    POrigen.nombre AS potrero_origen,
    PDestino.nombre AS potrero_destino,
    COUNT(*) AS cantidad,
    MAX(M.fecha) AS fecha_movimiento
FROM 
    movimientos M
JOIN 
    animal A ON M.ID_animal = A.ID_animal
JOIN 
    potrero POrigen ON M.ID_potreroOrigen = POrigen.ID_potrero
JOIN 
    potrero PDestino ON M.ID_potreroDestino = PDestino.ID_potrero
JOIN 
    categoria C ON A.ID_categoria = C.ID_categoria
GROUP BY 
    C.nombre, POrigen.nombre, PDestino.nombre, M.fecha
ORDER BY 
    fecha_movimiento DESC;

