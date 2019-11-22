CREATE OR ALTER PROCEDURE Project.RetrieveMovieShowTime
	@MovieId INT
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.MovieId = @MovieId;
GO