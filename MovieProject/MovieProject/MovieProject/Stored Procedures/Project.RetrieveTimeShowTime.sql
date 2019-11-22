CREATE OR ALTER PROCEDURE Project.RetrieveTimeShowTime
	@Time TIME
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.[Time] = @Time;
GO