CREATE OR ALTER PROCEDURE Project.RatingOverTime
	@StartDate DATE,
	@EndDate DATE
AS
SELECT M.[Name], M.Rating
FROM Project.Movie M
	INNER JOIN Project.ShowTime S ON M.MovieId = S.MovieId
WHERE S.[Date] BETWEEN @StartDate AND @EndDate
GROUP BY M.[Name], M.Rating
ORDER BY M.Rating DESC;
GO