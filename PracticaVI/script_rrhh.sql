CREATE TABLE RRHH;

USE RRHH;

drop table Empleados;


CREATE TABLE Departamentos (
	id_departamento int PRIMARY KEY IDENTITY (1,1),
  nombre_departamento VARCHAR (50) not NULL

);


CREATE TABLE Empleados (
  id_empleado int PRIMARY KEY  IDENTITY (1,1),
  nombre_empleado VARCHAR (50) not NULL,
  id_departamento int not NULL,
  estado_empleado bit not Null,
  FOREIGN KEY (id_departamento) REFERENCES Departamentos(id_departamento)
)

INSERT INTO Departamentos(nombre_departamento) VALUES 
('Seguridad'),('Contabilidad'),('Recursos Humanos'),('Ventas'),('Almac�n'),('Tecnolog�a'),('Gerencia')

