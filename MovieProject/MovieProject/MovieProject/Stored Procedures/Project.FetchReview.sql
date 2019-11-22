CREATE OR ALTER PROCEDURE Project.FetchReview
	@ReviewId INT
AS
SELECT R.ReviewId, R.MovieId, R.ViewerId, R.ReviewMessage, R.Rating, R.CreatedOn
FROM Project.Review R
WHERE R.ReviewId = @ReviewId;
GO