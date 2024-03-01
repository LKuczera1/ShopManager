create database shop_database

GO

use shop_database


create table workers(
worker_id int primary key identity(0,1),
login varchar(32) unique,
password varchar(32),
name varchar(32),
surname varchar(32))

insert into worker values('test','test','test','test');

--DROP DATABASE SHOP_DATABASE