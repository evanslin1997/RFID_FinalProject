create database RFID_TEST_DB;
USE RFID_TEST_DB;
CREATE TABLE `employee` (
	`id` nvarchar(32) NOT NULL,
	`name` NVARCHAR(50) NOT NULL,
    `city` nvarchar(15),
    `district` nvarchar(15),
    `address` nvarchar(50),
    `phoneNo` varchar(10),
	PRIMARY KEY (`id`) USING BTREE
);
insert into `employee` (iD, `name`, city, District, aDDress, phoneno)
values ("00950902FC193749E9CB436E484F7B81", "黃小熊", "台北市", "中正區", "寶慶路131號", "0912345678"); 
insert into `employee` (iD, `name`, city, District, aDDress, phoneno)
values ("6706B561D28E077A970D70845B711D83", "王汪汪", "台南市", "中西區", "啾啾路155號", "0988888888"); 


create TABLE `device` (
	`id` nvarchar(32) NOT NULL,
	`item_name` NVARCHAR(50) NOT NULL,
	PRIMARY KEY (`id`) USING BTREE
);


insert into `device` (id, item_name)
values ("1890E43CD43B931E59608168A3655F68", "樹莓派4B");


insert into `device` (id, item_name)
values ("B9E1F518AEE32EF11000E946D27DA390", "OLED螢幕");

insert into `device` (id, item_name)
values ("B96625E368AB95DC5BAD7820543F2C75", "router");

insert into `device` (id, item_name)
values ("2A5A518BAFD4A9AC601FFE0D41EDB276", "switch");



CREATE TABLE `asset_relationship` (
id nvarchar(32) NOT NULL,
owner_id nvarchar(32) NOT NULL, 
device_id nvarchar(32) NOT NULL,
user_id nvarchar(32) NOT NULL, 
is_return INT NOT NULL,
PRIMARY KEY (`id`) USING BTREE
);

insert into `asset_relationship` (id, owner_id, device_id, user_id, is_return)
values ("4D410405B4A52B6904B3C1EDC9F6C608", "00950902FC193749E9CB436E484F7B81", "1890E43CD43B931E59608168A3655F68", "6706B561D28E077A970D70845B711D83", 0);

insert into `asset_relationship` (id, owner_id, device_id, user_id, is_return)
values ("0CE54167377C8AD32452B83061509EF0", "00950902FC193749E9CB436E484F7B81", "B9E1F518AEE32EF11000E946D27DA390", "6706B561D28E077A970D70845B711D83", 0);

insert into `asset_relationship` (id, owner_id, device_id, user_id, is_return)
values ("4A62A894615C6637EAC5B4D0FD417966", "00950902FC193749E9CB436E484F7B81", "B96625E368AB95DC5BAD7820543F2C75", "6706B561D28E077A970D70845B711D83", 0);

insert into `asset_relationship` (id, owner_id, device_id, user_id, is_return)
values ("CBBD0896E1D638C947E1458529815261", "00950902FC193749E9CB436E484F7B81", "2A5A518BAFD4A9AC601FFE0D41EDB276", "6706B561D28E077A970D70845B711D83", 0);


select name from employee as e inner join asset_relationship on e.id = asset_relationship.owner_id;


select d.id, d.item_name,
(select name from employee as e inner join asset_relationship on e.id = asset_relationship.owner_id) as owner_name, 
(select name from employee as e inner join asset_relationship on e.id = asset_relationship.user_id) as user_name, 
a.is_return
from asset_relationship a
inner join device d
on a.device_id = d.id
inner join employee e
on a.owner_id = e.id;


select d.id as d_id, d.item_name as item_name from asset_relationship a
inner join employee e
on a.owner_id = e.id
inner join device d
on d.id = a.device_id
where e.id = "00950902FC193749E9CB436E484F7B81";

select d.id as d_id, d.item_name as item_name from asset_relationship as a inner join employee as e on a.owner_id = e.id inner join device d on d.id = a.device_id where e.id = "00950902FC193749E9CB436E484F7B81"; 

alter table employee add status int default 1;

alter table device add status int default 1;

select * from employee;

select * from device;

select a.owner_id, a.user_id from asset_relationship as a ;

select (select e.name as owner_name from employee as e inner join asset_relationship as a on a.owner_id = e.id where device.id='2A5A518BAFD4A9AC601FFE0D41EDB276'), (select e.name as user_name from employee as e inner join asset_relationship as a on a.user_id = e.id) from asset_relationship as a inner join device as d on d.id='2A5A518BAFD4A9AC601FFE0D41EDB276';

# query owner name 
select e.name as owner_name from employee as e inner join asset_relationship as a on a.owner_id = e.id where a.device_id='2A5A518BAFD4A9AC601FFE0D41EDB276';

# query user name 
select e.name as user_name from employee as e inner join asset_relationship as a on a.user_id = e.id where a.device_id='2A5A518BAFD4A9AC601FFE0D41EDB276';

alter table asset_relationship add column lend_date datetime default CURRENT_TIMESTAMP;

alter table asset_relationship add column return_date datetime default null;

select lend_date, return_date from asset_relationship where device_id="2A5A518BAFD4A9AC601FFE0D41EDB276";

select d.item_name from asset_relationship inner join device as d on d.id=asset_relationship.device_id where d.id="B9E1F518AEE32EF11000E946D27DA390";