CREATE PROCEDURE uspUpdateCustomer
@Branch nvarchar(50),
@Address nvarchar (100),
@City nvarchar (25),
@State nchar (2),
@Zip nchar (9),
@Phone nchar (10),
@Agent nvarchar (30),
@MAgmt nvarchar (1)
AS
UPDATE dbo.Customers
SET CustCity = @City,
		CustState = @State,
		CustZip = @Zip,
		CustPhone = @Phone,
		AuthAgent = @Agent,
		MAgmt = @MAgmt,
		CustAddress = @Address
WHERE Branch = @Branch;


--IS MY WHERE CLAUSE CORRECT
--OR SHOULD I HAVE USED INSTITUTION/BRANCH BUT NOT UPDATED THEM?


