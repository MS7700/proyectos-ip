CREATE DATABASE PRACTICA_2

USE PRACTICA_2

Create table nominaFerreteria (
    ID int identity(1,1) primary key,
	periodo varchar(6) not null,
	sueldo_bruto decimal not null,
	cedula varchar(11) not null,
	tipo_moneda varchar(3) not null,
	)

Create table nominaTSS (
    ID int identity(1,1) primary key,
	RNC varchar(9) not null,
	periodo varchar(6) not null,
	sueldo_bruto decimal not null,
	cedula varchar(11) not null,
	tipo_moneda varchar(3) not null,
	)