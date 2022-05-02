--Select
--ANSII
--case insensitive
-- <> ferqli olanlar (unitprice >< 10)
Select ContactName Name,CompanyName,City from Customers

Select * from Customers where City = 'London'

Select * from Products where CategoryID=1 or CategoryID=3

Select * from Products where CategoryID=1 and UnitPrice>=10

Select * from Products order by UnitPrice desc  --asc - ascending (artan) desc - descending (azalan-dusen)

Select * from Products where CategoryID=1 order by UnitPrice desc  

Select count(*) from Products where CategoryID=2

Select categoryId, count(*) from Products group by CategoryID

Select categoryId, count(*) from Products group by CategoryID having count(*)<10

Select categoryId, count(*) from Products  where UnitPrice>20 
group by CategoryID having count(*)<10

Select Products.ProductId,Products.ProductName,Products.UnitPrice,Categories.categoryName
from products inner join Categories
on Products.CategoryId = Categories.CategoryId
where Products.UnitPrice>10
--DTO - Data Transformation Object

Select * from Products p inner join [Order Details] od
on p.ProductID = od.ProductID

Select * from Products p left join [Order Details] od -- satisi olmayan urunleri getir (left join)
on p.ProductID = od.ProductID

Select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

Select * from Products p left join [Order Details] od 
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID