CREATE DATABASE CS_Test5

GO 
USE CS_Test5
GO

CREATE TABLE tblBooks
(
	pId int identity(1,1) PRIMARY KEY,
	pTitle TEXT,
	pPrice int,
	pImage TEXT,
	pCategoryId int
)

insert into tblBooks
values
('Sach 1', 120, 'image/st1.jpg', 1),
('Sach 2', 20, 'image/st2.jpg', 2),
('Sach 3', 220, 'image/st3.jpg', 3),
('Sach 4', 320, 'image/st4.jpg', 1),
('Sach 5', 130, 'image/st5.jpg', 2),
('Sach 6', 80, 'image/st6.jpg', 3)


