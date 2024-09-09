namespace Shapes;

class SQL_script_CreateAndSelect
{
	/*
		Задание 2	
		Запрос для выбора всех пар «Имя продукта – Имя категории»

		Select
			p.Name,
			ISNULL(c.Name, 'No Category')
		from Product p
		left join Product_Category pc on p.ID = pc.Product_ID
		left join Category c on c.ID = pc.Category_ID

		
		Прикладываю скрипт создания таблиц и тестовых данных

		create table Category(
		ID int primary key identity(1,1),
		Name nvarchar(500) Unique );

		create table Product(
		ID int primary key identity(1,1),
		Name nvarchar(500) Unique);

		create table Product_Category(
		ID int primary key identity(1,1),
		Product_ID int REFERENCES Product (ID),
		Category_ID int REFERENCES Category (ID),
		Unique (Product_ID, Category_ID)
		);

		insert into Category(name) 
		values ('Category1'),
			('Category2'),
			('Category3'),
			('Category4'),
			('Category5')

		insert into Product(name) 
		values ('Product1'),
			('Product2'),
			('Product3'),
			('Product4'),
			('Product5')

		insert into Product_Category(Product_ID,Category_ID) 
		values 	(1,1),(1,2),(1,3),
				(2,2),(2,3),(2,4),
				(3,3),(3,4),(3,5)
	
	*/
}
