CREATE PROCEDURE dbo.uspProductsWithoutProblems
AS
SELECT ProdNo, ProdDesc
FROM dbo.Products 
WHERE  ProdNo NOT IN (SELECT ProdNo FROM dbo.Problems);


exec dbo.uspProductsWithoutProblems;