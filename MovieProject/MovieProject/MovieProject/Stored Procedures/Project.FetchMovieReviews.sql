CREATE OR ALTER PROCEDURE Project.FetchMovieReviews
	@MovieId INT
AS
SELECT R.ReviewId, R.MovieId, R.ViewerId, R.ReviewMessage, R.Rating, R.CreatedOn
FROM Project.Review R
WHERE R.MovieId = @MovieId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveMovieReviews
	@MovieName NVARCHAR(128)
AS
SELECT R.ReviewId, R.MovieId, R.ViewerId, R.ReviewMessage, R.Rating, R.CreatedOn
FROM Project.Review R
	INNER JOIN Project.Movie M ON M.MovieId = R.MovieId
WHERE M.[Name] = @MovieName;
GO