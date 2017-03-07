CREATE PROCEDURE dbo.uspProblemsByProduct
AS
SELECT pr.ProdNo, pr.ProdDesc, 
			COUNT(*) AS Number_Of_Problems, 
			SUM(ISNULL(e.HoursWorked * e.CostHours,0) 
			+ISNULL(e.Mileage * e.CostMiles,0) 
			+ ISNULL(e.Misc,0) + ISNULL(e.Supplies,0)) AS Total_Cost,
			AVG(ISNULL(e.HoursWorked * e.CostHours,0) +ISNULL(e.Mileage * e.CostMiles,0) 
			+ ISNULL(e.Misc,0) + ISNULL(e.Supplies,0)) AS Average_Cost
FROM dbo.Expenses e
INNER JOIN dbo.Problems p ON p.TicketNo = e.TicketNo AND p.ProbNo = e.ProbNo
INNER JOIN dbo.Products pr ON p.ProdNo = pr.ProdNo
GROUP BY pr.ProdNo, pr.ProdDesc;
