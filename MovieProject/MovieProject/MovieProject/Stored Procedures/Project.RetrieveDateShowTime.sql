CREATE OR ALTER PROCEDURE Project.RetrieveDateShowTime
	@Date DATE
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.[Date] = @Date;
GO