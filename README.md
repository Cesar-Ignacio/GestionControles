
## Gestión de Controles
Permite crear  controles, asignar las marcas disponibles y una imagen. Puede eliminarse y modificarse .
Las consultas se hacen por las marcas y se podrá descontar la cantidad digitada.

## Base de Datos
### DER
[![Captura-de-pantalla-2022-04-29-231027.png](https://i.postimg.cc/d074WP8Z/Captura-de-pantalla-2022-04-29-231027.png)](https://postimg.cc/kVmQ4HY7)
#### Script de la base de datos utilizada
```sql
create  database Control
ON PRIMARY
(
NAME='control_dat',
Filename='C:\DRIVERS\control.mdf'
)

USE Control
go


--Creacion de tablas

--tabla control
create table Control
(
codControl varchar(10) PRIMARY KEY NOT NULL,
cantidad int not null,
imagen image not null 
)

--tabla Marca
create table Marca
(
codMarca varchar(10) PRIMARY KEY NOT NULL,
nombreMarca nchar(30) not null
)

--tabla Control x Marca

create table Control_X_Marca
(
codControl varchar(10) NOT NULL,
codMarca varchar(10) NOT NULL,
CONSTRAINT FK_CodCon FOREIGN KEY (codControl) REFERENCES Control(CodControl),
CONSTRAINT FK_CodMar FOREIGN KEY (codMarca) REFERENCES Marca(CodMarca),
CONSTRAINT PK_ControlMarca PRIMARY KEY (codControl,codMarca)
)
go

--PROCEDIMIENTOS ALMACENADOS

	--INSERTA CONTROLES
	
	CREATE PROCEDURE sp_InsertControl
	@codControl varchar(10),
	@cantidad int,
	@imagen image
	AS
	INSERT INTO Control(codControl,cantidad,imagen)
	SELECT @codControl,@cantidad,@imagen
	GO

	

	--INSERTAR MARCAS
	CREATE PROCEDURE sp_InsertarMarca
	@codMarca varchar(10),
	@nombreMarca nchar(30)
	AS
	INSERT INTO Marca(codMarca,nombreMarca)
	SELECT @codMarca,@nombreMarca
	GO
	--INSERTAR MARCA X CONTROL
	CREATE PROCEDURE sp_InsertaMarcaControl
	@codControl varchar(10),
	@codMarca varchar(10)
	AS
	INSERT INTO Control_X_Marca (codControl,codMarca)
    SELECT @codControl,@codMarca
	GO
	--ACTUALIZAR CONTROL
	CREATE PROCEDURE spActualizarControl
	@codControl varchar(10),
	@cantidad int,
	@imagen image
	AS
	UPDATE Control set cantidad=@cantidad, imagen=@imagen where codControl=@codControl
	GO
	--ELIMINAR CONTROL MARCA
	CREATE PROCEDURE sp_EliminarMarcaControl
	@codControl varchar(10)
	AS
	delete from Control_X_Marca where codControl=@codControl
	GO
--Carga de datos

--CONTROL
--EXEC sp_InsertControl 'CR7',5
--EXEC sp_InsertControl 'CR8',5
--EXEC sp_InsertControl 'CR10',5
--EXEC sp_InsertControl 'CR11',5
--EXEC sp_InsertControl 'CR14',5

--MARCAS
EXEC sp_InsertarMarca 'M01','Philips'
EXEC sp_InsertarMarca 'M02','JVS'
EXEC sp_InsertarMarca 'M03','Sony'
EXEC sp_InsertarMarca 'M04','Fisher'
EXEC sp_InsertarMarca 'M05','Toshiba'
EXEC sp_InsertarMarca 'M06','Hitachi'
EXEC sp_InsertarMarca 'M07','Admiral'
EXEC sp_InsertarMarca 'M08','AIWA'
EXEC sp_InsertarMarca 'M09','Ansonic'
EXEC sp_InsertarMarca 'M010','APEX'
EXEC sp_InsertarMarca 'M011','Philco'
EXEC sp_InsertarMarca 'M012','LG'
EXEC sp_InsertarMarca 'M013','Noblex'
EXEC sp_InsertarMarca 'M014','Sanyo'
EXEC sp_InsertarMarca 'M015','Top House'
EXEC sp_InsertarMarca 'M016','Samsung'
EXEC sp_InsertarMarca 'M017','RCA'
EXEC sp_InsertarMarca 'M018','Panasonic'

--CONTROL MARCAS

EXEC sp_InsertaMarcaControl 'CR11','M011'

EXEC sp_InsertaMarcaControl 'CR11','M012'

EXEC sp_InsertaMarcaControl 'CR20','M09'

EXEC sp_InsertaMarcaControl 'CR20','M05'

EXEC sp_InsertaMarcaControl 'pro014','M03'


--TRIGER 
go
CREATE trigger tr_eliminacionControl
on Control
instead of delete
as
begin
	DECLARE @codControl varchar(10)
	Select @codControl=codControl from deleted
	delete from Control_X_Marca where codControl=@codControl 
	delete from Control where codControl=@codControl
   
end
go

---

```
## Vistas

[![Captura-de-pantalla-2022-04-27-092707.png](https://i.postimg.cc/x1S840vW/Captura-de-pantalla-2022-04-27-092707.png)](https://postimg.cc/N5pQyvP4)
[![Captura-de-pantalla-2022-04-27-092544.png](https://i.postimg.cc/FKTKz3M4/Captura-de-pantalla-2022-04-27-092544.png)](https://postimg.cc/DWbhYJfj)
[![Captura-de-pantalla-2022-04-27-093625.png](https://i.postimg.cc/tTfCtyRv/Captura-de-pantalla-2022-04-27-093625.png)](https://postimg.cc/34XTYsv2)
