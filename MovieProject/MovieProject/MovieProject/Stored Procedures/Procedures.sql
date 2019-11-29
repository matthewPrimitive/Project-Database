-- Report Query #1 --

CREATE OR ALTER PROCEDURE Project.RatingOverTime
	@StartDate DATE,
	@EndDate DATE
AS
SELECT M.[Name], M.Rating
FROM Project.Movie M
	INNER JOIN Project.ShowTime S ON M.MovieId = S.MovieId
WHERE S.[Date] BETWEEN @StartDate AND @EndDate
GROUP BY M.[Name], M.Rating
ORDER BY M.Rating DESC;
GO


-- Report Query #2 -- By removing the commented out part, we can have number of viewers for each individual showing. IDK which is better

CREATE OR ALTER PROCEDURE Project.MostViewed
	@StartDate DATE,
	@EndDate DATE
AS
SELECT M.[Name],/* S.[Date], S.[Time], */ISNULL(COUNT(DISTINCT T.TicketId), 0) AS NumberOfViewers
FROM Project.Movie M
	LEFT JOIN Project.ShowTime S ON M.MovieId = S.MovieId
	LEFT JOIN Project.Ticket T ON T.ShowTimeId = S.ShowTimeId
WHERE S.[Date] BETWEEN @StartDate AND @EndDate
GROUP BY M.[Name]/*, S.[Date], S.[Time]*/
ORDER BY NumberOfViewers DESC;
GO

-- Report Query #3 -- Kind of need more tickets for this to make any sense
CREATE OR ALTER PROCEDURE Project.BestTime
	AS
SELECT S.[Time], DATENAME(WEEKDAY, S.[Date]) AS DayOfTheWeek, COUNT(DISTINCT T.TicketId) AS NumberOfViewers
FROM Project.ShowTime S
	LEFT JOIN Project.Ticket T ON T.ShowTimeId = S.ShowTimeId
	INNER JOIN Project.Movie M ON M.MovieId = S.MovieId
GROUP BY DATENAME(WEEKDAY, S.[Date]), S.[Time]
ORDER BY COUNT(DISTINCT T.TicketId) DESC
GO


-- Report Query #4 --
CREATE OR ALTER PROCEDURE Project.HighestRatedActors
	AS
SELECT A.[Name], (SUM(M.Rating) / COUNT(DISTINCT M.MovieId)) AS OverallRating
FROM Project.Movie M
	INNER JOIN Project.MovieActor MA ON MA.MovieId = M.MovieId
	INNER JOIN Project.Actor A ON A.ActorId = MA.ActorId
GROUP BY A.[Name]
ORDER BY OverallRating DESC;
GO

-- GENERAL QUERIES WE MAY NEED --

-- Queries on Movie Table --

CREATE OR ALTER PROCEDURE Project.FetchMovie
	@MovieId INT
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.MovieId = @MovieId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveMovie
	@MovieName NVARCHAR(128)
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.[Name] = @MovieName;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveGenre
	@Genre NVARCHAR(128)
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.Genre = @Genre;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveDirector
	@DirectorName NVARCHAR(128)
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
WHERE M.Director = @DirectorName;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveMovies
AS
SELECT M.MovieId, M.[Name], M.Genre, M.Rating, M.Director
FROM Project.Movie M
GO

-- Queries on Review Table

-- Could easily edit to include movie name as well
CREATE OR ALTER PROCEDURE Project.FetchReview
	@ReviewId INT
AS
SELECT R.ReviewId, R.MovieId, R.ViewerId, R.ReviewMessage, R.Rating, R.CreatedOn
FROM Project.Review R
WHERE R.ReviewId = @ReviewId;
GO

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

CREATE OR ALTER PROCEDURE Project.FetchViewerReviews
	@ViewerId INT
AS
SELECT R.ReviewId, R.MovieId, R.ViewerId, R.ReviewMessage, R.Rating, R.CreatedOn
FROM Project.Review R
WHERE R.ViewerId = @ViewerId;
GO

-- Queries on Viewer Table
CREATE OR ALTER PROCEDURE Project.FetchViewer
	@ViewerId INT
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.ViewerId = @ViewerId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveViewerOnEmail
	@Email NVARCHAR(128)
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.Email = @Email;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveViewerOnName
	@Name NVARCHAR(128)
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.[Name] = @Name;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveViewerOnGender
	@Gender NVARCHAR(32)
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.Gender = @Gender;
GO

-- Queries on Ticket Table --
CREATE OR ALTER PROCEDURE Project.FetchTicket
	@TicketId INT
AS
SELECT T.TicketId, T.ViewerId, T.ShowTimeId, T.PurchasedOn
FROM Project.Ticket T
WHERE T.TicketId = @TicketId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveViewerTicket
	@ViewerId INT
AS
SELECT T.TicketId, T.ViewerId, T.ShowTimeId, T.PurchasedOn
FROM Project.Ticket T
WHERE T.ViewerId = @ViewerId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveShowTimeTicket
	@ShowTimeId INT
AS
SELECT T.TicketId, T.ViewerId, T.ShowTimeId, T.PurchasedOn
FROM Project.Ticket T
WHERE T.ShowTimeId = @ShowTimeId;
GO

-- Queries on ShowTime Table --
CREATE OR ALTER PROCEDURE Project.FetchShowTime
	@ShowTimeId INT
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.ShowTimeId = @ShowTimeId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveMovieShowTime
	@MovieId INT
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.MovieId = @MovieId;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveTimeShowTime
	@Time TIME
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.[Time] = @Time;
GO

CREATE OR ALTER PROCEDURE Project.RetrieveDateShowTime
	@Date DATE
AS
SELECT S.ShowTimeId, S.MovieId, S.[Time], S.[Date], S.Price
FROM Project.ShowTime S
WHERE S.[Date] = @Date;
GO

-- Queries on Actor Table --
CREATE OR ALTER PROCEDURE Project.FetchActor
	@ActorId INT
AS
SELECT A.ActorId, A.[Name]
FROM Project.Actor A
WHERE A.ActorId = @ActorId;
GO

CREATE OR ALTER PROCEDURE Project.FetchActorOnName
	@Name NVARCHAR(128)
AS
SELECT A.ActorId, A.[Name]
FROM Project.Actor A
WHERE A.[Name] = @Name;
GO
