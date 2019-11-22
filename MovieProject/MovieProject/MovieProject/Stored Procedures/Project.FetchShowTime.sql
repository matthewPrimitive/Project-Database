CREATE OR ALTER PROCEDURE Project.FetchShowTime
	@ShowTimeId INT
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.ShowTimeId = @ShowTimeId;
GO