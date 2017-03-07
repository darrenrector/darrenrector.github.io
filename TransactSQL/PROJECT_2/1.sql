CREATE FUNCTION dbo.ufnTotalCost(@TicketNo int)
RETURNS MONEY
AS
BEGIN
	DECLARE @TotalCost money;
	SELECT @TotalCost = SUM(ISNULL(HoursWorked * CostHours,0) + ISNULL(Mileage * CostMiles,0) + ISNULL(Misc,0) + ISNULL(Supplies,0))
	FROM Expenses
	WHERE TicketNo = @TicketNo;

	RETURN @TotalCost;

END