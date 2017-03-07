CREATE PROCEDURE uspAddCustomer
@Institution nvarchar (100),
@Branch nvarchar (50),
@Address nvarchar (100),
@City nvarchar (25),
@State nchar (2),
@Zip nchar (9),
@Phone nchar (10),
@Agent nvarchar (30),
@MAgmt nvarchar (1)
AS
INSERT INTO dbo.Customers (Institution, Branch, CustAddress, CustCity, CustState, CustZip, CustPhone, AuthAgent, MAgmt)
VALUES (@Institution, @Branch, @Address, @City, @State, @Zip, @Phone, @Agent, @MAgmt);

--exec dbo.uspAddCustomer 'Biaggis', 'Maple Grove', '5445 Boone Ave', 'Maple Grove', 'MN', '55428', '3203090976', 'D RECTOR', 'Y'