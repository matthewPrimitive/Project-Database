CREATE OR ALTER PROCEDURE Project.RetrieveDirector
	@DirectorName NVARCHAR(128)
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.Director = @DirectorName;
GO