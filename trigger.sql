use Farmacia

create table factura (
	ID_FACTURA int NOT NULL PRIMARY KEY IDENTITY (1,1),
	NOMBRE_CLIENTE varchar(50) NOT NULL,
	FECHA datetime NOT NULL,
	MONTO int NOT NULL,
	PAGADO BIT NOT NULL
)

create table CXC (
	NOMBRE_CLIENTE varchar(50) NOT NULL, 
	SALDO int NOT NULL
)

insert into CXC values ('Eduardo Duran', 10000)
insert into factura values ('Eduardo Duran', GETDATE(), 5000, 1)
GO

CREATE TRIGGER TG_ACTUALIZAR_CXC
	ON factura
	AFTER INSERT
AS
BEGIN
	declare @PAGADO BIT
	SET @PAGADO = (SELECT PAGADO FROM inserted)
	--declare @SALDO int
	--SET @SALDO = (SELECT SALDO from CXC)
	declare @MONTO int
	SET @MONTO = (SELECT MONTO from inserted)
	declare @NOMBRE_CLIENTE varchar(50)
	SET @NOMBRE_CLIENTE = (SELECT NOMBRE_CLIENTE from inserted)

PRINT @PAGADO 
PRINT @NOMBRE_CLIENTE
PRINT @MONTO
--PRINT @SALDO
IF @PAGADO = 1
	update CXC set SALDO = SALDO - @MONTO where NOMBRE_CLIENTE = @NOMBRE_CLIENTE
IF @PAGADO = 0
	update CXC set SALDO = SALDO + @MONTO where NOMBRE_CLIENTE = @NOMBRE_CLIENTE
END

select * from CXC
select * from factura
delete from factura
drop trigger [TG_ACTUALIZAR_CXC]
