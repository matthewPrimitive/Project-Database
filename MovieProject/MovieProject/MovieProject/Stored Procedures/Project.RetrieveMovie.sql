CREATE OR ALTER PROCEDURE Project.RetrieveMovie
	@MovieName NVARCHAR(128)
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.[Name] = @MovieName;
GO