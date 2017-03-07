CREATE PROCEDURE uspCustomersWithoutProblems
AS
SELECT Institution, Branch
FROM dbo.Customers
WHERE Institution NOT IN(SELECT Institution FROM dbo.Tickets);
