Create database BBMS;
use BBMS;
Create Table customerDetails(
customerID int not null identity,
fName varchar(20),
lName varchar(20),
dateofBirth Date,
phone varchar(20),
address varchar(100),
gender varchar (20),
nationality varchar(50),
constraint pk_c primary key (CustomerID)
)

create table bill(
billNumber int not null identity,
billDate varchar (15),
customerID int,
constraint pk_b primary key(billNumber),
constraint fk_b foreign key(customerID) references customerDetails(customerID)
)

create table item(
itemCode int not null identity,
itemName varchar(50),
rate float,
constraint pk_i primary key(itemCode)
)

Create table itemBill(
billnumber int,
itemCode int,
quantity int,
constraint ck_ib primary key(billnumber,itemcode),
constraint fk_ib foreign key(billNumber) references bill(billNumber),
constraint fk_ii foreign key(itemCode) references item(itemCode)
)
select * from item
select * from itemBill
select * from customerDetails
select * from bill

create table adminInfo(
username varchar(20),
password varchar(20),
fName varchar(20),
lName varchar(20),
dateofBirth date,
phone varchar(20),
address varchar(100),
gender varchar (20),
nationality varchar(50),
constraint pk_AI primary key (username)
)

drop table itemBill
Drop table bill

select * from bill;
delete from adminInfo 
where password ='sdfdsfdf';
select * from item
update item
set itemName = 'Coat',rate =555
where itemCode = 4;
select * from customerDetails

update customerDetails
set fName = 'Blah'
where customerID =2;

Create table bill(
billNumber int not null,
constraint pk_b primary key (billNumber)
)

create table billItem(
billNumber int,
itemCode int,
customerID int,
quantity int,
total float,
date date,
Constraint fk_b foreign key (billNumber) references bill(billNumber),
constraint fk_ii foreign key(itemCode) references item(itemCode),
constraint fk_c foreign key(customerID) references customerDetails(customerID)
)

drop table billItem

select * from bill
insert into bill 
values(1)
select* from bill
delete from bill where billNumber=5;

select i.itemName,i.rate,b.quantity,b.total from item as i,billItem as b where b.itemCode = i.itemCode and b.itemCode=1;

select * from billitem;
