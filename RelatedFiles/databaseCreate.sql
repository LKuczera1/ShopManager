create database shop_database

GO

use shop_database


create table employees(
employee_id int primary key identity(0,1),
login varchar(32) unique not null,
password varchar(32) not null,
name varchar(32) not null,
surname varchar(32) not null,
check (password!=''))

--DROP DATABASE SHOP_DATABASE