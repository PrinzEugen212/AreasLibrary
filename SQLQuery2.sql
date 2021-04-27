CREATE TABLE Product
(
Id INT PRIMARY KEY IDENTITY,
ProductName nvarchar(50)
)

CREATE TABLE Category
(
Id INT PRIMARY KEY IDENTITY,
CategoryName nvarchar(50)
)

CREATE TABLE PrCat
(
IdPr INT,
IdCat INT,
FOREIGN KEY (IdPr) REFERENCES Product (Id),
FOREIGN KEY (IdCat) REFERENCES Category (Id)
)

INSERT INTO Product (ProductName)
VALUES ('iPhone'),
('Nokia'),
('Apple'),
('Cabage'),
('Cucamber');

INSERT INTO Category (CategoryName)
VALUES ('electronics'),
('vagatables'),
('Manufactory');


INSERT INTO PrCat (IdPr, IdCat)
VALUES (1, 1),
(2, 1),
(2, 3),
(3, 1),
(3, 2)

SELECT pr.ProductName, cat.CategoryName FROM Product as pr
LEFT JOIN PrCat as prCat on prCat.IdPr = pr.Id
LEFT JOIN Category as cat on cat.Id = prCat.IdCat