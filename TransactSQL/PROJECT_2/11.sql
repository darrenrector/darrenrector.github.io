CREATE PROCEDURE uspProblemsWithMultiResolution
AS
SELECT TicketNo, ProbNo, count(*)
FROM Resolutions
GROUP BY TicketNo, ProbNo
HAVING count(*) > 1;