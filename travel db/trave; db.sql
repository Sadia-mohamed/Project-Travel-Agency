create database travelagencyDB
 create table loging_tbl (
 username nvarchar(50), 
 passwords nvarchar(50));

 insert into loging_tbl values('shaariif', '123123')
 select * from loging_tbl

 create table registrationinfo (
 firstname nvarchar(50),
  surname nvarchar(50),
   addresss nvarchar(50),
    tel nvarchar(50),
	 email nvarchar(50))

	insert into registrationinfo (firstname,surname,addresss,tel,email) values
	('abdulaahi','shariif', 'L.A' , '617004648', 'apdulahisherrif@gmail.com' );

 create table destinationinfo (
   destination nvarchar(50),
	 des_price int)




	  insert into destinationinfo values('hargeisa - 5 days in laascaanod', 100);
 
 select * from destinationinfo


 create table recipt_tb (
 fullname nvarchar(50),
 depature nvarchar(50),
 distanation nvarchar(50),
 accomadtion nvarchar(50),
 flight_standerd nvarchar(50),
 total_price nvarchar(50))

 drop table recipt


 select * from loging_tbl
 select * from registrationinfo
 select * from destinationinfo
 select * from recipt_tb




delete  FROM loging_tbl WHERE passwords = '123123'


 
 


