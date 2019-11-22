CREATE OR ALTER PROCEDURE Project.MostViewed
	@StartDate DATE,
	@EndDate DATE
AS
SELECT M.[Name],/* S.[Date], S.[Time], */ISNULL(COUNT(DISTINCT T.TicketId), 0) AS NumberOfViewers
FROM Project.Movie M
	LEFT JOIN Project.ShowTime S ON M.MovieId = S.MovieId
	LEFT JOIN Project.Ticket T ON T.ShowTimeId = S.ShowTimeId
WHERE S.[Date] BETWEEN @StartDate AND @EndDate
GROUP BY M.[Name]/*, S.[Date], S.[Time]*/
ORDER BY NumberOfViewers DESC;
GO