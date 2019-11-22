CREATE OR ALTER PROCEDURE Project.BestTime
	AS
SELECT S.[Time], DATENAME(WEEKDAY, S.[Date]) AS DayOfTheWeek, COUNT(DISTINCT T.TicketId) AS NumberOfViewers
FROM Project.ShowTime S
	LEFT JOIN Project.Ticket T ON T.ShowTimeId = S.ShowTimeId
	INNER JOIN Project.Movie M ON M.MovieId = S.MovieId
GROUP BY DATENAME(WEEKDAY, S.[Date]), S.[Time]
ORDER BY COUNT(DISTINCT T.TicketId) DESC
GO