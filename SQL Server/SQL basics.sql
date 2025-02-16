--create database DB;
--create table tab1(Id int, Name varchar(20), Age int, Address nvarchar(100), Mark int);
--insert into tab1 values(1,'Bryan',22,'Kaloor',55);
--insert into tab1 values(2,'Ameer',22,'Ponnekara',30);
--insert into tab1 values(3,'Hari',22,'Eddapally',33),(4,'Vishwajith',22,'Chennai',54);

select * from tab1;
select name,age,mark from tab1;
select * from tab1 where id=2;
select * from tab1 where name='Hari';
select * from tab1 where name='Hari' and age=22;
select * from tab1 where name='Hari' or mark=55; 

--delete from tab1 where id=4;

update tab1 set age=25,address='kakkanad' where id=1;


