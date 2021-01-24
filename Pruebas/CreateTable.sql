use  Renta
/*drop table pagos
drop table alquiler
drop table carro
drop table cliente*/

--1.1. Creación de base de datos, tablas, llaves foráneas y auto-incrementos correctamente creadas. 
Create table carro(
placa varchar (8) not null PRIMARY KEY,
marca varchar (15),
modelo varchar (15),
costo decimal (19,4),
disponible char (3)
)
Create table cliente(
cedula int  not null PRIMARY KEY,
nombre varchar (20),
telefono1 int ,
telefono2 int
)
Create table Alquiler(
id_alquiler int NOT NULL PRIMARY KEY,
placa varchar (8),
cedula int,
fecha date,
dias_alquiler int,
valortotal decimal,
saldo decimal,
abono_inicial decimal,
devuelto varchar,
CONSTRAINT FK_carro_placa FOREIGN KEY (placa) REFERENCES carro(placa),
CONSTRAINT FK_cliente_cedula FOREIGN KEY (cedula) REFERENCES cliente(cedula)
)
Create table pagos(
id_pago int ,
id_alquiler int,
fecha date ,
valor int,
CONSTRAINT FK_Alquiler_id_alquiler FOREIGN KEY (id_alquiler) REFERENCES Alquiler(id_alquiler)
)

