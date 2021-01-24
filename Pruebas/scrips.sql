use Renta
--1.2.Cuantos alquileres ha tenido un carro específico desde una fecha específica.
select * from alquiler where PLACA='AAA999' and fecha >= '01/01/2020' and fecha <= '31/01/2020'

--1.3.El total de saldo en un día específico.
select sum(saldo)as saldo_dia from alquiler where fecha = '10/05/2020'

--1.4.Realice una consulta así:
select alquiler.cedula, cliente.nombre, fecha as Fecha_alquiler, dias_alquiler as Tiempo_Alquilado, saldo,
alquiler.placa, marca from alquiler
inner join cliente ON cliente.cedula = alquiler.cedula
inner join carro ON carro.placa = alquiler.placa

--1.5. Los clientes que no han alquilado en un periodo específico.
select distinct (cliente.nombre) from alquiler inner join cliente ON cliente.cedula = alquiler.cedula  
where  alquiler.fecha <= '03/03/2020' or alquiler.fecha >= '31/05/2020' --select * from pagos

--1.6.Realice la siguiente consulta desde una fecha específica.
select a.fecha, count (p.id_pago) No_pagos, sum(p.valor)TotalPagado, max(p.valor) MaxValor from pagos p inner join alquiler a 
ON p.id_alquiler=a.id_alquiler and a.fecha >= '01/01/2020' and a.fecha <= '31/03/2020'
group by a.fecha, p.id_pago, p.valor, p.valor 

--1.7.una consulta así: consolidado por carros en un periodo específico.
select a.placa codcarro, c.modelo,c.marca, c.costo, count (dias_alquiler) as cuantos_alquileres, sum(id_alquiler)as TotalAlquiler
from alquiler a, carro c
where a.placa=c.placa and a.fecha >= '01/01/2020' and a.fecha <= '31/03/2020'--and a.placa = 'ubn340' and c.marca = 'kia'
group by id_alquiler,c.marca,a.placa, c.modelo, c.costo

--1.8.El primer alquiler de un cliente
select * from cliente c inner join alquiler a ON c.cedula=a.cedula
where a.id_alquiler = (select MIN(id_alquiler) from alquiler a where a.cedula = 1022976737 )













