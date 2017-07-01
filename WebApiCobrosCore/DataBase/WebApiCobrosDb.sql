use WebApiCobrosDb;

create table Cobros
(  
   IdCobro int identity primary key,
   Fecha datetime,
   Referencia varchar(50),
   IdRemoto int,
   IdRuta int,
   Mora money,
   Monto Money,
   Latitud float,
   Longitud float,
   EsNulo  varchar(19),


);
insert into Cobros values('12/03/2019','GrupoA',1,2,222,322,322,342,'Si')
GO
insert into Cobros values('12/03/2019','GrupoB',1,2,222,322,322,342,'Si')
GO
insert into Cobros values('12/03/2019','GrupoC',1,2,222,322,322,342,'Si')
GO
insert into Cobros values('12/03/2019','GrupoD',1,2,222,322,322,342,'Si')
select * from Cobros;
