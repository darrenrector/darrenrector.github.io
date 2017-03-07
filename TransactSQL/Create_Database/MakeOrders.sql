CREATE TABLE [Customers]
([CustomerNo] int IDENTITY(1,1) NOT NULL,
 [LName] nvarchar(50) NOT NULL,
 [FName] nvarchar(35) NOT NULL,
 [MInit] nchar(1) NULL,
 [Addr1] nvarchar(50) NOT NULL,
 [Addr2] nvarchar(50) NULL,
 [City] nvarchar(50) NOT NULL,
 [State] nchar(2) NOT NULL,
 [Zip] nchar(5) NOT NULL,
 [Zip4] nchar(4) NULL,
 [Phone] nchar(10) NULL,
 [EMail] nvarchar(50) NULL)
GO

CREATE TABLE [Products]
([ProductNo] int IDENTITY(1,1) NOT NULL,
 [ProdDesc] nvarchar(150) NOT NULL,
 [QtyOnHand] smallint NOT NULL,
 [ReorderPoint] smallint NOT NULL,
 [UnitCost] smallmoney NOT NULL,
 [UnitPrice] smallmoney NOT NULL)
GO

CREATE TABLE [Orders]
([OrderNo] int IDENTITY(1,1) NOT NULL,
 [OrderDate] smalldatetime NOT NULL,
 [CustomerNo] int NOT NULL)
GO

CREATE TABLE [OrderDetail]
([OrderNo] int NOT NULL,
 [LineNo] smallint NOT NULL,
 [ProductNo] int NOT NULL,
 [Qty] smallint NOT NULL,
 [UnitPrice] smallmoney NOT NULL)
GO

ALTER TABLE [Customers]
ADD CONSTRAINT [PK_Customers] PRIMARY KEY ([CustomerNo]),
    CONSTRAINT [CK_Customers_Zip] CHECK ([Zip] LIKE N'[0-9][0-9][0-9][0-9][0-9]'),
    CONSTRAINT [CK_Customers_Zip4] CHECK ([Zip4] LIKE N'[0-9][0-9][0-9][0-9]'),
    CONSTRAINT [CK_Customers_Phone] CHECK ([Phone] LIKE N'[1-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]')
GO

ALTER TABLE [Products]
ADD CONSTRAINT [PK_Products] PRIMARY KEY ([ProductNo]),
    CONSTRAINT [DF_Products_QtyOnHand] DEFAULT (0) FOR [QtyOnHand], 
    CONSTRAINT [DF_Products_ReorderPoint] DEFAULT (5) FOR [ReorderPoint],
    CONSTRAINT [CK_Products_QtyOnHand] CHECK ([QtyOnHand] >= 0),
    CONSTRAINT [CK_Products_ReorderPoint] CHECK ([ReorderPoint] >= 0),
    CONSTRAINT [CK_Products_UnitCost] CHECK ([UnitCost] >= 0),
    CONSTRAINT [CK_Products_UnitPrice] CHECK ([UnitPrice] >= 0)
GO

ALTER TABLE [Orders]
ADD CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderNo]),
    CONSTRAINT [DF_Orders_OrderDate] DEFAULT (GETDATE()) FOR [OrderDate],
    CONSTRAINT [CK_Orders_OrderDate] CHECK ([OrderDate] <= GETDATE())
GO

ALTER TABLE [OrderDetail]
ADD CONSTRAINT [PK_OrderDetail] PRIMARY KEY ([OrderNo],[LineNo]),
    CONSTRAINT [DF_OrderDetail_Qty] DEFAULT (1) FOR [Qty],
    CONSTRAINT [CK_OrderDetail_Qty] CHECK ([Qty] > 0),
    CONSTRAINT [CK_OrderDetail_UnitPrice] CHECK ([UnitPrice] >= 0)
GO

ALTER TABLE [Orders]
ADD CONSTRAINT [FK_Orders_Customers] FOREIGN KEY ([CustomerNo])
       REFERENCES [Customers] ([CustomerNo])
GO

ALTER TABLE [OrderDetail]
ADD CONSTRAINT [FK_OrderDetail_Orders] FOREIGN KEY ([OrderNo])
       REFERENCES [Orders] ([OrderNo]),
    CONSTRAINT [FK_OrderDetail_Products] FOREIGN KEY ([ProductNo])
       REFERENCES [Products] ([ProductNo])
GO

INSERT INTO [Customers] ([LName],[FName],[MInit],[Addr1],[Addr2],[City],[State],[Zip],[Zip4],[Phone],[EMail])
VALUES (N'Adams',N'Andrew',N'A',N'1234 Main Street',NULL,N'Minneapolis',N'MN',N'55402',NULL,N'6125551212',N'Andy@Adams.com')

INSERT INTO [Customers] ([LName],[FName],[MInit],[Addr1],[Addr2],[City],[State],[Zip],[Zip4],[Phone],[EMail])
VALUES (N'Barnes',N'Betty',N'B',N'89 S. Jump Avenue',N'Apt 201',N'St. Paul',N'MN',N'55422',N'0089',N'6515551313',N'Betty@Barnes.com')

INSERT INTO [Customers] ([LName],[FName],[MInit],[Addr1],[Addr2],[City],[State],[Zip],[Zip4],[Phone],[EMail])
VALUES (N'Cass',N'Carrie',NULL,N'2089 Elm Drive',NULL,N'Bloomington',N'MN',N'55418',NULL,N'9525551414',N'Carrie@Cass.com')

INSERT INTO [Customers] ([LName],[FName],[MInit],[Addr1],[Addr2],[City],[State],[Zip],[Zip4],[Phone],[EMail])
VALUES (N'Dobbs',N'Dana',N'D',N'762 Smart Road',N'Suite 9',N'New Hope',N'MN',N'55411',N'0762',N'7635551515',N'Dana@Dobbs.com')

INSERT INTO [Products] ([ProdDesc],[QtyOnHand],[ReorderPoint],[UnitCost],[UnitPrice])
VALUES (N'HP Deskjet 992',3,5,79.95,89.95)

INSERT INTO [Products] ([ProdDesc],[QtyOnHand],[ReorderPoint],[UnitCost],[UnitPrice])
VALUES (N'MS Office 2007',100,15,379.95,489.95)

INSERT INTO [Products] ([ProdDesc],[QtyOnHand],[ReorderPoint],[UnitCost],[UnitPrice])
VALUES (N'Adobe Acrobat',8,DEFAULT,69.95,79.95)

INSERT INTO [Products] ([ProdDesc],[QtyOnHand],[ReorderPoint],[UnitCost],[UnitPrice])
VALUES (N'Corel Draw',53,50,99.95,102.95)

INSERT INTO [Orders] ([OrderDate],[CustomerNo])
VALUES (N'28 Aug 2008',3)

INSERT INTO [Orders] ([OrderDate],[CustomerNo])
VALUES (N'23 Sep 2008',1)

INSERT INTO [Orders] ([OrderDate],[CustomerNo])
VALUES (N'7 Aug 2008',3)

INSERT INTO [OrderDetail] ([OrderNo],[LineNo],[ProductNo],[Qty],[UnitPrice])
VALUES (1,1,1,DEFAULT,89.95)

INSERT INTO [OrderDetail] ([OrderNo],[LineNo],[ProductNo],[Qty],[UnitPrice])
VALUES (1,2,4,2,102.95)

INSERT INTO [OrderDetail] ([OrderNo],[LineNo],[ProductNo],[Qty],[UnitPrice])
VALUES (2,1,2,3,489.95)

INSERT INTO [OrderDetail] ([OrderNo],[LineNo],[ProductNo],[Qty],[UnitPrice])
VALUES (3,1,3,2,79.95)

INSERT INTO [OrderDetail] ([OrderNo],[LineNo],[ProductNo],[Qty],[UnitPrice])
VALUES (3,2,1,1,89.95)

