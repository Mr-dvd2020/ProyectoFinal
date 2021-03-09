------------------------------------------------
-------Crear base de datos de la tienda-------
------------------------------------------------
use master
go
if exists(select * from sysdatabases where name in ('Tienda'))
   drop database Tienda --si la BD existe se elimina
go
  --crear la base de datos en blanco
create database Tienda
go
------------------------------------------------
--------CREAR LAS TABLAS DE	Tienda-------
------------------------------------------------
use Tienda
go
------------------Tabla:Usuario----------------
create table Usuario
( --lista de atributos
	Correo varchar(30),
	Contrasena varchar(30),
	Nombres varchar(50),
  	Tipo_usuario varchar (50),
	--definir la clave primaria
	primary key(Correo)
)
go

------------------Tabla:Producto----------------
create table Producto
( --lista de atributos
	CodigoProducto varchar(6),
	Descripcion varchar(50),
	Unidad varchar(10),
	Cantida int,
	PrecioUnitario numeric(5,2) null,
	--definir la clave primaria
	primary key(CodigoProducto)
)
go
------------------Tabla:Venta----------------
create table Venta
( --lista de atributos
	CodigoBoleta varchar(6) not null,
 	CodigoProducto varchar(6) not null,
	NombreProducto varchar(20) null,
	NroProducto int null,
	MontoUnitario varchar(20) null,
	MontoTotal decimal(5,2) null,
	Hora varchar(20) null,
	--definir la clave primaria
	primary key(CodigoBoleta,CodigoProducto),
)
go

------------------Tabla: Arqueo de Caja--------
create table Arqueo
(
	CodBoleta varchar(30),
	PrecioTotal decimal(5,2) null,
	--definir la clave primaria
	primary key(CodBoleta) 
)
go
-----------------------------------------------------------
--SCRIPT PARA INSERTAR DATOS EN Tienda
----------------------------------------------------------
use Tienda
go
--Insertar datos en Usuario---------------------
insert into Usuario Values ('131050@unsaac.edu.pe','131050','Tomas Apaza Moreno','Administrador')
insert into Usuario Values ('161731@unsaac.edu.pe','161731','Juan Pinares Quispe','Cajero')
insert into Usuario Values ('182934@unsaac.edu.pe','182934','Pepito Pinares Quispe','Cajero')
insert into Usuario Values ('182909@unsaac.edu.pe','182909','Julia Pilar Rosas','Cajero')
insert into Usuario Values ('182348@unsaac.edu.pe','182348','Raul Jorge Sanches','Cajero')
insert into Usuario Values ('162971@unsaac.edu.pe','162971','Ana Claudia Santander','Cajero')
insert into Usuario Values ('165678@unsaac.edu.pe','165678','Piero Alvaro Quispe','Cajero')
go
--Insertar datos en Producto---------------------
insert into Producto Values ('AR001','Arroz','Kilo',200,3.50)
insert into Producto Values ('AZ002','Azucar','Kilo',150,4.50)
insert into Producto Values ('LE001','Leche','Lata',400,3.00)
insert into Producto Values ('PA002','Papa','Kilo',300,2.50)
insert into Producto Values ('PA001','Pantalon','Unidad',200,15.00)
insert into Producto Values ('AL003','Alcohol','Litro',230,12.50)
insert into Producto Values ('CH002','Chocolate','Unidad',100,3.50)
insert into Producto Values ('TV003','TV','Unidad',100,350.00)
insert into Producto Values ('CC001','Carne Cerdo','Kilo',940,13.00)
insert into Producto Values ('PO001','Pollo','Kilo',400,8.00)
insert into Producto Values ('AT001','Atún','Lata',100,4.50)
insert into Producto Values ('YO001','Yogurt','Litro',100,5.00)
insert into Producto Values ('PA003','Pan','Gramo',200,7.00)
insert into Producto Values ('MA001','Mantequilla','Paquete',500,10.00)
insert into Producto Values ('QU001','Queso','Kilo',356,16.00)
insert into Producto Values ('CR001','Carne Res','Kilo',720,16.00)
insert into Producto Values ('TA001','Tallarín','Gramo',600,2.20)
insert into Producto Values ('LE002','Lechuga','Unidad',349,2.00)
insert into Producto Values ('TO001','Tomate','Kilo',350,2.00)
insert into Producto Values ('NA001','Naranja','Kilo',400,2.00)
insert into Producto Values ('MA002','Manzana','Kilo',100,4.00)
insert into Producto Values ('PI001','Piña','Unidad',100,2.00)
insert into Producto Values ('PA004','Papaya','Kilo',365,3.00)
insert into Producto Values ('AM001','Agua Mineral','Litro',577,1.50)
insert into Producto Values ('GA001','Gaseosa','Litro',600,1.50)
insert into Producto Values ('CE001','Cebolla','Kilo',349,2.70)
insert into Producto Values ('HU001','Huevo','Docena',300,5.90)
insert into Producto Values ('PL001','Plátano','Kilo',200,3.80)
insert into Producto Values ('VE001','Vestido','Unidad',100,101.00)
insert into Producto Values ('ZD003','Zapatillas Deportivas','Unidad',200,280.00)
insert into Producto Values ('ZA003','Zapatos','Unidad',670,260.00)

go
/*
--Insertar datos en Venta---------------------
go

select *
	from Usuario
select *
	from Venta
	
	*/