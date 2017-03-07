CREATE PROCEDURE uspAddTechnician
@LName nvarchar (25),
@FName nvarchar (15),
@MInit nchar (1),
@Email nvarchar (50),
@DeptName nvarchar (15),
@TechPhone nchar (10),
@HRate money,
@NewTechNo int OUTPUT
AS
INSERT INTO dbo.Technicians (LName, FName, MInit, Email, DeptName, TechPhone, HRate)
VALUES (@LName, @FName, @MInit, @Email, @DeptName, @TechPhone, @HRate);

SET @NewTechNo = @@IDENTITY
GO 
RETURN