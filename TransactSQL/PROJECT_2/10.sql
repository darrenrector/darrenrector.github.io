CREATE PROCEDURE uspProblemsByTechnician
AS
SELECT pr.TechNo, t.TechNo,
			COUNT(*) AS Number_Of_Problems,
			SUM(ISNULL(e.HoursWorked * e.CostHours,0) 
			+ISNULL(e.Mileage * e.CostMiles,0) 
			+ ISNULL(e.Misc,0) + ISNULL(e.Supplies,0)) AS Total_Cost,
			AVG(ISNULL(e.HoursWorked * e.CostHours,0) +ISNULL(e.Mileage * e.CostMiles,0) 
			+ ISNULL(e.Misc,0) + ISNULL(e.Supplies,0)) AS Average_Cost
FROM dbo.Expenses e
INNER JOIN dbo.Problems pr ON pr.TicketNo = e.TicketNo AND pr.ProbNo = e.ProbNo
INNER JOIN dbo.Technicians  t ON t.TechNo = pr.TechNo
GROUP BY pr.TechNo, t.TechNo;
