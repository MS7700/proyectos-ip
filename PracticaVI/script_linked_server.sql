CREATE DATABASE DWH

use dwh;
CREATE TABLE Articulos (
  id_articulo int not null IDENTITY(1,1),
  descripcion NCHAR (10) not NULL
)

CREATE TABLE Clientes (
  id_cliente int not NULL IDENTITY (1,1),
  nombre_cliente VARCHAR (50) not NULL
)

CREATE TABLE Empleados (
  id_empleado int not NULL IDENTITY (1,1),
  nombre_empleado VARCHAR (50) not NULL,
  departamento_empleado VARCHAR (50) not NULL,
  estado_empleado bit not NULL
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

select * from [LAPTOP-6NR7NCCT\MSSQLSERVER01].[DWH].[dbo].[Empleados];

--insert desde un servidor remoto

insert into [LAPTOP-6NR7NCCT\MSSQLSERVER01].[DWH].[dbo].[Empleados] (nombre_empleado,departamento_empleado,estado_empleado) values ('Gabriel Ventura','Seguridad',1);

--update desde un servidor remoto

update openquery(‘[LAPTOP-6NR7NCCT\MSSQLSERVER01], ‘select nombre_empleado from [DWH].[dbo].[Empleados] where nombre_empleado = 'Gabriel Ventura'’)
set nombre_empleado = 'Pedro Báez'

--DELETE

delete from openqueryopenquery(‘[LAPTOP-6NR7NCCT\MSSQLSERVER01], ‘select * from [DWH].[dbo].[Empleados]
      where nombre_empleado = 'Pedro Báez'’)