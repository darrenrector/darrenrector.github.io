CREATE PROCEDURE uspProblemsByCustomer
AS
SELECT c.Institution, c.Branch, 
			COUNT(*) AS Number_Of_Problems, 
			SUM(ISNULL(e.HoursWorked * e.CostHours,0) 
			+ISNULL(e.Mileage * e.CostMiles,0) 
			+ ISNULL(e.Misc,0) + ISNULL(e.Supplies,0)) AS Total_Cost,
			AVG(ISNULL(e.HoursWorked * e.CostHours,0) +ISNULL(e.Mileage * e.CostMiles,0) 
			+ ISNULL(e.Misc,0) + ISNULL(e.Supplies,0)) AS Average_Cost
FROM dbo.Expenses e
INNER JOIN dbo.Tickets t ON t.TicketNo = e.TicketNo
INNER JOIN dbo.Customers c ON c.Institution = t.Institution AND c.Branch = t.Branch
GROUP BY c.Institution, c.Branch;




