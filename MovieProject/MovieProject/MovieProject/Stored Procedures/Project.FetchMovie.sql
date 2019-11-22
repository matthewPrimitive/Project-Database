CREATE OR ALTER PROCEDURE Project.FetchMovie
	@MovieId INT
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.MovieId = @MovieId;
GO