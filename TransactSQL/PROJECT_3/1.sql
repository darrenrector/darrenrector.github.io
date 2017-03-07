USE CCIS2781;

GO

DECLARE @HoursWorked int;
DECLARE @CostHours money;
DECLARE @Mileage int;
DECLARE @CostMiles money;
DECLARE @Supplies money;
DECLARE @Misc money;
DECLARE @TotalLabor money;
DECLARE @TotalTravel money;
DECLARE @TotalSupplies money;
DECLARE @TotalMisc money;
DECLARE @TotalCost money;

SET @TotalLabor = 0;
SET @TotalTravel = 0;
SET @TotalSupplies = 0;
SET @TotalMisc = 0;
SET @TotalCost = 0;

DECLARE curTotals CURSOR
FOR SELECT HoursWorked, CostHours, ISNULL(Mileage, 0), ISNULL(CostMiles, 0), ISNULL(Supplies, 0), ISNULL(Misc, 0) FROM dbo.Expenses

OPEN curTotals

FETCH NEXT FROM curTotals INTO @HoursWorked, @CostHours, @Mileage, @CostMiles, @Supplies, @Misc;
WHILE @@FETCH_STATUS = 0
		BEGIN
				
				SET @TotalLabor = @TotalLabor + (@CostHours * @HoursWorked);
				SET @TotalTravel = @TotalTravel + (@Mileage * @CostMiles);
				SET @TotalSupplies = @TotalSupplies + @Supplies;
				SET @TotalMisc = @TotalMisc + @Misc
				SET @TotalCost = @TotalLabor + @TotalTravel + @TotalSupplies + @TotalMisc;
				
				FETCH NEXT FROM curTotals INTO @HoursWorked, @CostHours, @Mileage, @CostMiles, @Supplies, @Misc;
		END

CLOSE curTotals;

DEALLOCATE curTotals;

PRINT @TotalLabor;
PRINT @TotalTravel;
PRINT @TotalSupplies;
PRINT @TotalMisc;
PRINT @TotalCost;
