CREATE DATABASE FStore2
GO
USE FStore2
GO
CREATE TABLE Member( 
	MemberId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	Email VARCHAR(100) NOT NULL,
	CompanyName VARCHAR(40) NOT NULL,
	City VARCHAR(15) NOT NULL,
	Country VARCHAR(15) NOT NULL,
	Password VARCHAR(30) NOT NULL,
)
go
CREATE TABLE [Order](
 OrderId INT NOT NULL IDENTITY PRIMARY KEY,
 MemberId INT NOT NULL,
 OrderDate DATETIME NOT NULL,
 RequiredDate DATETIME NULL,
 ShippedDate DATETIME NULL,
 Freight MONEY NULL,
 CONSTRAINT FK_MemberOrder FOREIGN KEY (MemberId)
 REFERENCES dbo.Member (MemberId)
)
GO
CREATE TABLE Product(
	ProductId INT NOT NULL IDENTITY PRIMARY KEY,
	CategoryId INT NOT NULL,
	ProductName VARCHAR(40) NOT NULL,
	Weight VARCHAR(20) NOT NULL,
	UnitPrice MONEY NOT NULL,
	UnitslnStock INT NOT NULL,
)
GO
CREATE TABLE [OrderDetail](
	OrderID INT NOT NULL,
	ProductId INT NOT NULL,
	UnitPrice MONEY NOT NULL,
	Quantity INT NOT NULL,
	Discount FLOAT NOT NULL,
	PRIMARY KEY (OrderID,ProductId),
	CONSTRAINT FK_OrderOrderDetail FOREIGN KEY (OrderID)
	REFERENCES dbo.[Order](OrderId),
	CONSTRAINT FK_ProductOderDetail FOREIGN KEY(ProductId)
	REFERENCES dbo.Product(ProductId)
)


