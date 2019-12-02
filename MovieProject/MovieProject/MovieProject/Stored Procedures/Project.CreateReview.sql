CREATE OR ALTER PROCEDURE Project.CreateReview
	@ViewerId INT,
	@MovieId INT,
	@ReviewMessage NVARCHAR,
	@Rating DECIMAL(2,1)
AS
INSERT Project.Review(MovieId, ViewerId, ReviewMessage,  Rating)
VALUES (@MovieId, @ViewerId, @ReviewMessage, @Rating)
GO
