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

Drop TABLE `device`;

insert into `device` (id, item_name)
values ("1890E43CD43B931E59608168A3655F68", "樹莓派4B");

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
