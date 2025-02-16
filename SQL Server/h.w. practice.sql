--select * from Personal_details;
--select * from educational_details;

--select pd.[name],pd.[address],sum(ed.[mark]) from Personal_details as pd join educational_details as ed on pd.id=ed.id group by pd.name,pd.[address]; 

--select pd.[name],pd.[address],sum(ed.[mark]) from Personal_details as pd left join educational_details as ed on pd.id=ed.id group by pd.[name],pd.[address];

--select name, sum(salary) from Employee group by name having sum(salary) >= 30000
--select sum(salary) as total from Employee 
