--insert into T1 values('Bryan',22);
select * from T1;

--distinct
select distinct name,age from T1;

--like
select * from T1 where name like '%n';
select * from T1 where name like 'b%';
select * from T1 where name like '%r%';
select * from T1 where name like '_r%';
select * from T1 where name like '__r%';

--alter table
alter table t1 add Phone varchar(10);
alter table T1 drop column Phone;