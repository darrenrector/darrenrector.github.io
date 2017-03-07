CREATE PROCEDURE uspUpdateTechnician
@TechNo int,
@DeptName nvarchar (15),
@TechPhone nchar (10),
@HRate money
AS
UPDATE dbo.Technicians
SET DeptName = @DeptName,
		TechPhone = @TechPhone,
		HRate = @HRate
WHERE TechNo = @TechNo;