CREATE OR ALTER PROCEDURE Project.HighestRatedActors
	AS
SELECT A.[Name], (SUM(M.Rating) / COUNT(DISTINCT M.MovieId)) AS OverallRating
FROM Project.Movie M
	INNER JOIN Project.MovieActor MA ON MA.MovieId = M.MovieId
	INNER JOIN Project.Actor A ON A.ActorId = MA.ActorId
GROUP BY A.[Name]
ORDER BY OverallRating DESC;
GO