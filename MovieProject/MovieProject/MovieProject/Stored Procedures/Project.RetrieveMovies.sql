CREATE OR ALTER PROCEDURE Project.RetrieveMovies
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
GO