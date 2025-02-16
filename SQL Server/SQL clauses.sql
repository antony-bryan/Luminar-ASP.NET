--insert into tab1 values(1,'Bryan',25,'kakkanad',90),(1,'Bryan',25,'kakkanad',100),(1,'Bryan',25,'kakkanad',95)
--insert into tab1 values(2,'Ameer',22,'ponekara',40)
--select * from tab1;

--scalar Function/aggregate functions

----select COUNT(id) as Count_id from tab1;
----select min(mark) as min_mark from tab1;
----select max(mark) as max_mark from tab1;
----select sum(mark) as sum_mark from tab1;
----select avg(mark) as avg_mark from tab1;

--oder by

----select * from tab1 order by mark
----select * from tab1 order by mark asc
----select * from tab1 order by mark desc

--group by and having clause

----select name,age,address,sum(mark) as total from tab1 group by Name,age,address
----select name,age,address,sum(mark) as total from tab1 group by name,age,address having sum(mark)>60;

--sub query

select name from tab1 where mark=(select max(mark) from tab1);