select * from T1;
select * from T2;

--JOIN

select T1.name,T1.Age,T2.Address,T2.Pincode from T1 join T2 on T1.id=T2.id;
select T1.name,T1.age,T2.address,T2.pincode from T1 join T2 on T1.id=T2.id where T1.id=1;

select T1.name,T1.Age,T2.Address,T2.Pincode from T1 inner join T2 on T1.id=T2.id; --same as join
select T1.name,T1.Age,T2.Address,T2.Pincode from T1 left join T2 on T1.id=T2.id;  --all values on left side and matching values on right side
select T1.name,T1.Age,T2.Address,T2.Pincode from T1 right join T2 on T1.id=T2.id; --all values on the right side and only matching values on the left side




