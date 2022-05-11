create database NCKH_QLHH
go
use NCKH_QLHH
go
create table dbo.QLHH_main
(
	id int PRIMARY KEY,
	Product nvarchar(30) NULL,
	Price int Null,
	Ex date Null
)
go
insert into QLHH_main values (123456, N'Trà xanh không độ', 12000, '2022/08/04');
insert into QLHH_main values (123457, N'Sting dâu', 12000, '2022/12/07');
insert into QLHH_main values (123458, N'Coca cola vị nguyên bản', 15000, '2023/01/02');
insert into QLHH_main values (123459, N'Pepsi vị chanh không calo', 13000, '2022/04/13');
insert into QLHH_main values (123450, N'Red Bull', 12000, '2022/11/11');
insert into QLHH_main values (123451, N'Nabati phô mai', 10000, '2023/05/05');
insert into QLHH_main values (123452, N'Bánh Bon sợi thịt gà 300g', 40000, '2023/01/01');
insert into QLHH_main values (123453, N'Ostar rong biển', 17000, '2022/08/04');
insert into QLHH_main values (123454, N'Ostar kim chi', 17000, '2022/08/04');
insert into QLHH_main values (123455, N'Gà ủ muối', 107000, '2022/08/04');
insert into QLHH_main values (123449, N'Há cảo Cầu Tre', 78000, '2022/08/04');
insert into QLHH_main values (123448, N'Trứng gà vỉ 12', 32000, '2022/08/04');
go

create table dbo.QLHH_tinh_tien
(
	id int references QLHH_main(id),
	Quanlity int null,
	Total int null,
	PRIMARY KEY(id)
)
go
