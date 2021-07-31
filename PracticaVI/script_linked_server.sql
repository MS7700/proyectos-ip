CREATE DATABASE DWH

CREATE TABLE Articulos (
  id_articulo int not null IDENTITY(1,1),
  descripcion NCHAR (10) not NULL
)

CREATE TABLE Clientes (
  id_cliente int not NULL IDENTITY (1,1),
  nombre_cliente VARCHAR (50) not NULL
)

CREATE TABLE Region (
  id_region int not NULL IDENTITY (1,1),
  descripcion_region VARCHAR (50) not NULL,
  estado char (1)
)

CREATE TABLE Vendedores (
  id_vendedor int not NULL IDENTITY (1,1),
  nombre_vendedor VARCHAR(50) not null
)

CREATE TABLE Factura_Ventas (
  id_articulo int not null,
  id_region int not null,
  id_cliente int not null,
  id_vendedor int not NULL
)

--select desde un servidor remoto

select * from nombre_servidor.DWH.dbo.Factura_Ventas

--insert desde un servidor remoto

insert into [nombre_servidor].[DWH].[dbo].Clientes (nombre_cliente) VALUES ('Eduardo Duran')

--update desde un servidor remoto

update openquery(‘nombre_servidor, ‘select nombre_vendedor from dbo.Vendedores where nombre_vendedor = 'Eduardo Duran'’)
set nombre_vendedor = ‘Sebastian Lopez’

--DELETE

delete from openqueryopenquery(‘nombre_servidor, ‘select * from dbo.Clientes
      where nombre_cliente = 'Eduardo Duran'’)