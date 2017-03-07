CREATE PROCEDURE uspAddProduct
@Description nvarchar(250),
@ProdHS nvarchar(1),
@Manufacturer nvarchar (100),
@NewProdNo int OUTPUT
AS
INSERT INTO dbo.Products (ProdDesc, ProdHS, Manufacturer)
VALUES (@Description, @ProdHS, @Manufacturer);

SET @NewProdNo = @@IDENTITY
GO 
RETURN
