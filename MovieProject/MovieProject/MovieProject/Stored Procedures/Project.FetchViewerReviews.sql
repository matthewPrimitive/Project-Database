CREATE OR ALTER PROCEDURE Project.FetchViewerReviews
	@ViewerId INT
AS
SELECT R.ReviewId, R.MovieId, R.ViewerId, R.ReviewMessage, R.Rating, R.CreatedOn
FROM Project.Review R
WHERE R.ViewerId = @ViewerId;
GO