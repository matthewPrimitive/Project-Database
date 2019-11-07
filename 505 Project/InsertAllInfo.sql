--INSERT MOVIES

DECLARE @MovieStaging TABLE
(
	MovieId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL UNIQUE,
	Genre NVARCHAR(64) NOT NULL,
	Rating DECIMAL(2,1) NULL,
	Director NVARCHAR(64) NOT NULL
);

INSERT @MovieStaging([Name], Genre, Director)
VALUES
(N'Good Will Hunting',	N'Drama', N'Gus Van Sant'),
(N'Star Wars: Episode IV - A New Hope',	N'Science Fiction', N'George Lucas'),
(N'The Shining', N'Horror', N'Stanley Kubrick'),
(N'The Martian', N'Drama', N'Ridley Scott'),
(N'Star Wars: Episode V - The Empire Strikes Back', N'Science Fiction',N'Irvin Kershner'),
(N'The Hobbit: An Unexpected Journey', N'Adventure', N'Peter Jackson'),
(N'Harry Potter and the Sorcerer''s Stone', N'Adventure', N'Chris Columbus'),
(N'The Terminator', N'Action', N'James Cameron'),
(N'Annabelle', N'Horror', N'John R. Leonetti');	

MERGE Project.Movie M
USING @MovieStaging S ON M.MovieId = S.MovieId
WHEN MATCHED AND S.[Name] <> M.[Name] THEN
	UPDATE
	SET
	M.[Name] = S.[Name],
	Genre = S.Genre,
	Director = S.Director
WHEN NOT MATCHED THEN
	INSERT([Name], Genre, Director)
	VALUES (S.[Name], S.Genre, S.Director);
GO
--INSERT VIEWERS

DECLARE @ViewerStaging TABLE
(
	ViewerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL,
	Gender NVARCHAR(32) NOT NULL,
	Email NVARCHAR(64) NOT NULL UNIQUE,
	BirthDate DATE NOT NULL,
	Username NVARCHAR(32) NOT NULL
);

INSERT @ViewerStaging
VALUES
	(N'Rikesh Neale', N'Male', N'rikeshneale@user.com', N'1990/09/30', N'rikeshneale'),
	(N'Peyton Ortiz', N'Male', N'peytonortiz@user.com', N'1992/02/02', N'peytonortiz'),
	(N'Kristie Xiong', N'Female', N'Kristiexiong@user.com', N'1984/03/28', N'Kristiexiong'),
	(N'Burhan Wilkes', N'Male', N'Burhanwilkes@user.com', N'1975/11/24', N'Burhanwilkes'),
	(N'Kuba Aguirre', N'Male', N'kubajaguirre@user.com', N'1998/08/02', N'kubajaguirre'),
	(N'Haaris Coffey', N'Male', N'Haariscoffey@user.com', N'1999/08/05', N'Haariscoffey'),
	(N'Kaydee Hansen', N'Female', N'KaydeeHansen@user.com', N'1995/05/05', N'KaydeeHansen'),
	(N'Gerald Gamble', N'Male', N'Geraldgamble@user.com', N'1965/06/22', N'Geraldgamble'),
	(N'Zach Gough', N'Male', N'Zachgough@user.com', N'1994/07/17', N'Zachgough'),
	(N'Pedro Worthington', N'Male', N'Pedroworthington@user.com', N'1943/08/02', N'Pedroworthington')

MERGE Project.Viewer V
USING @ViewerStaging S ON S.ViewerId = V.ViewerId
WHEN MATCHED AND S.Username <> V.Username THEN
	UPDATE
	SET
	[Name] = S.[Name],
	Gender = S.Gender,
	Email = S.Email,
	BirthDate = S.BirthDate,
	Username = S.Username
WHEN NOT MATCHED THEN
	INSERT([Name], Gender, Email, BirthDate, Username)
	VALUES(S.[Name], S.Gender, S.Email, S.BirthDate, S.Username);

GO
-- INSERT DATA INTO Review TABLE

INSERT Project.Review(MovieId, ViewerId, ReviewMessage, Rating)
VALUES
	(4, 1, N'Great Movie!', 4.5),
	(4, 3, N'Average, at best', 2.8),
	(4, 9, N'Neato', 5),
	(7, 1, N'I love Daniel Radcliffe', 4.7),
	(7, 6, N'Terrible movie', 1.2),
	(8, 10, N'James Cameron killed it', 5),
	(8, 7, N'Cool machines should have won', 3.6),
	(8, 5, N'Big fan', 2),
	(9, 2, N'I hate scary movies', 1),
	(9, 8, N'I love scary movies', 5),
	(1, 2, N'I want to marry Matt Damon', 4.9),
	(1, 10, N'Janitors r cool', 4)
GO	
--INSERT AVERAGE RATING INTO APPROPRIATE MOVIE

DECLARE @ReviewAverage TABLE
(
	MovieId INT,
	Rating DECIMAL(2,1)
);

INSERT @ReviewAverage(MovieId, Rating)
SELECT R.MovieId, SUM(R.Rating) / COUNT(R.ReviewId) AS AverageRating
FROM Project.Review R
	INNER JOIN Project.Movie M ON M.MovieId = R.MovieId
GROUP BY R.MovieId

MERGE Project.Movie M
USING @ReviewAverage R ON R.MovieId = M.MovieId
WHEN MATCHED THEN
	UPDATE
	SET
	M.Rating = R.Rating;

GO
-- INSERT ACTOR
DECLARE @ActorStaging TABLE
(
	ActorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL
);

INSERT @ActorStaging([Name])
VALUES
(N'Robin Williams'),
(N'Mark Hamill'),
(N'Jack Nicholson'),
(N'Matt Damon'),
(N'Alfre Woodard'),
(N'Martin Freeman'),
(N'Daniel Radcliffe'),
(N'Arnold Schwarzenegger'),
(N'Ward Horton'),
(N'Michael Biehn'),
(N'Harrison Ford'),
(N'Shelley Duvall'),
(N'Jessica Chastain'),
(N'Emma Watson'),
(N'Ian McKellen'),
(N'Rupert Grint'),
(N'Lina Hamilton'),
(N'Annabelle Wall'),
(N'Ben Affleck'),
(N'Carrie Fisher'),
(N'Danny Lloyd'),
(N'Kristen Wiig'),
(N'Richard Armitage');

MERGE Project.Actor A
USING @ActorStaging S ON A.ActorId = S.ActorId
WHEN MATCHED AND S.[Name] <> A.[Name] THEN
	UPDATE
	SET
	A.[Name] = S.[Name]
WHEN NOT MATCHED THEN
	INSERT([Name])
	VALUES (S.[Name]);

GO
--INSERT MOVIEACTOR

INSERT Project.MovieActor(MovieId, ActorId)
VALUES
(1, 4),
(1, 1),
(1, 19),
(2, 20),
(2, 2),
(2, 11),
(3, 12),
(3, 3),
(3, 21),
(4, 4),
(4,13),
(4, 22),
(5, 2),
(5, 11),
(5, 20),
(6, 6),
(6, 15),
(6, 23),
(7, 14),
(7, 16),
(7, 7),
(8, 8),
(8, 17),
(8, 10),
(9, 9),
(9, 18),
(9, 5)
GO
--INSERT SHOWTIME

INSERT Project.ShowTime
VALUES
(1,	'09:30:00',	'2019-11-11',	5.5),
(1,	'13:30:00',	'2019-11-11',	7.5),
(1,	'17:00:00',	'2019-11-11',	12.5),
(3,	'09:30:00',	'2019-11-11',	5.5),
(3,	'13:30:00',	'2019-11-11',	7.5),
(3,	'17:00:00',	'2019-11-11',	12.5),
(4,	'13:30:00',	'2019-11-11',	7.5),
(4,	'17:00:00',	'2019-11-11',	12.5),
(5,	'09:30:00',	'2019-11-11',	5.5),
(5,	'13:30:00',	'2019-11-11',	7.5),
(5,	'17:00:00',	'2019-11-11',	12.5),
(6,	'17:00:00',	'2019-11-11',	12.5),
(8,	'13:30:00',	'2019-11-11',	7.5),
(8,	'17:00:00',	'2019-11-11',	12.5),
(1,	'09:30:00',	'2019-11-12',	5.5),
(1,	'13:30:00',	'2019-11-12',	7.5),
(1,	'17:00:00',	'2019-11-12',	12.5),
(3,	'09:30:00',	'2019-11-12',	5.5),
(3,	'13:30:00',	'2019-11-12',	7.5),
(3,	'17:00:00',	'2019-11-12',	12.5),
(4,	'13:30:00',	'2019-11-12',	7.5),
(4,	'17:00:00',	'2019-11-12',	12.5),
(5,	'09:30:00',	'2019-11-12',	5.5),
(5,	'13:30:00',	'2019-11-12',	7.5),
(5,	'17:00:00',	'2019-11-12',	12.5),
(6,	'17:00:00',	'2019-11-12',	12.5),
(8,	'13:30:00',	'2019-11-12',	7.5),
(8,	'17:00:00',	'2019-11-12',	12.5),
(1,	'09:30:00',	'2019-11-13',	5.5),
(1,	'13:30:00',	'2019-11-13',	7.5),
(1,	'17:00:00',	'2019-11-13',	12.5),
(3,	'09:30:00',	'2019-11-13',	5.5),
(3,	'13:30:00',	'2019-11-13',	7.5),
(3,	'17:00:00',	'2019-11-13',	12.5),
(4,	'13:30:00',	'2019-11-13',	7.5),
(4,	'17:00:00',	'2019-11-13',	12.5),
(5,	'09:30:00',	'2019-11-13',	5.5),
(5,	'13:30:00',	'2019-11-13',	7.5),
(5,	'17:00:00',	'2019-11-13',	12.5),
(6,	'17:00:00',	'2019-11-13',	12.5),
(8,	'13:30:00',	'2019-11-13',	7.5),
(8,	'17:00:00',	'2019-11-13',	12.5),
(1,	'09:30:00',	'2019-11-14',	5.5),
(1,	'13:30:00',	'2019-11-14',	7.5),
(1,	'17:00:00',	'2019-11-14',	12.5),
(3,	'09:30:00',	'2019-11-14',	5.5),
(3,	'13:30:00',	'2019-11-14',	7.5),
(3,	'17:00:00',	'2019-11-14',	12.5),
(4,	'13:30:00',	'2019-11-14',	7.5),
(4,	'17:00:00',	'2019-11-14',	12.5),
(5,	'09:30:00',	'2019-11-14',	5.5),
(5,	'13:30:00',	'2019-11-14',	7.5),
(5,	'17:00:00',	'2019-11-14',	12.5),
(6,	'17:00:00',	'2019-11-14',	12.5),
(8,	'13:30:00',	'2019-11-14',	7.5),
(8,	'17:00:00',	'2019-11-14',	12.5),
(1,	'09:30:00',	'2019-11-15',	5.5),
(1,	'13:30:00',	'2019-11-15',	7.5),
(1,	'17:00:00',	'2019-11-15',	12.5),
(3,	'09:30:00',	'2019-11-15',	5.5),
(3,	'13:30:00',	'2019-11-15',	7.5),
(3,	'17:00:00',	'2019-11-15',	12.5),
(4,	'13:30:00',	'2019-11-15',	7.5),
(4,	'17:00:00',	'2019-11-15',	12.5),
(5,	'09:30:00',	'2019-11-15',	5.5),
(5,	'13:30:00',	'2019-11-15',	7.5),
(5,	'17:00:00',	'2019-11-15',	12.5),
(6,	'17:00:00',	'2019-11-15',	12.5),
(8,	'13:30:00',	'2019-11-15',	7.5),
(8,	'17:00:00',	'2019-11-15',	12.5),
(1,	'09:30:00',	'2019-11-16',	5.5),
(1,	'13:30:00',	'2019-11-16',	7.5),
(1,	'17:00:00',	'2019-11-16',	12.5),
(3,	'09:30:00',	'2019-11-16',	5.5),
(3,	'13:30:00',	'2019-11-16',	7.5),
(3,	'17:00:00',	'2019-11-16',	12.5),
(4,	'13:30:00',	'2019-11-16',	7.5),
(4,	'17:00:00',	'2019-11-16',	12.5),
(5,	'09:30:00',	'2019-11-16',	5.5),
(5,	'13:30:00',	'2019-11-16',	7.5),
(5,	'17:00:00',	'2019-11-16',	12.5),
(6,	'17:00:00',	'2019-11-16',	12.5),
(8,	'13:30:00',	'2019-11-16',	7.5),
(8,	'17:00:00',	'2019-11-16',	12.5),
(1,	'09:30:00',	'2019-11-17',	5.5),
(1,	'13:30:00',	'2019-11-17',	7.5),
(1,	'17:00:00',	'2019-11-17',	12.5),
(3,	'09:30:00',	'2019-11-17',	5.5),
(3,	'13:30:00',	'2019-11-17',	7.5),
(3,	'17:00:00',	'2019-11-17',	12.5),
(4,	'13:30:00',	'2019-11-17',	7.5),
(4,	'17:00:00',	'2019-11-17',	12.5),
(5,	'09:30:00',	'2019-11-17',	5.5),
(5,	'13:30:00',	'2019-11-17',	7.5),
(5,	'17:00:00',	'2019-11-17',	12.5),
(6,	'17:00:00',	'2019-11-17',	12.5),
(8,	'13:30:00',	'2019-11-17',	7.5),
(8,	'17:00:00',	'2019-11-17',	12.5),
(1,	'09:30:00',	'2019-11-18',	5.5),
(1,	'13:30:00',	'2019-11-18',	7.5),
(1,	'17:00:00',	'2019-11-18',	12.5),
(3,	'09:30:00',	'2019-11-18',	5.5),
(3,	'13:30:00',	'2019-11-18',	7.5),
(3,	'17:00:00',	'2019-11-18',	12.5),
(4,	'13:30:00',	'2019-11-18',	7.5),
(4,	'17:00:00',	'2019-11-18',	12.5),
(5,	'09:30:00',	'2019-11-18',	5.5),
(5,	'13:30:00',	'2019-11-18',	7.5),
(5,	'17:00:00',	'2019-11-18',	12.5),
(6,	'17:00:00',	'2019-11-18',	12.5),
(8,	'13:30:00',	'2019-11-18',	7.5),
(8,	'17:00:00',	'2019-11-18',	12.5),
(2, '09:30:00', '2019-08-16',	5.5),
(2, '09:30:00', '2019-08-17',	5.5),
(2, '17:00:00', '2019-08-16',	12.5),
(2, '17:00:00', '2019-08-17',	12.5),
(7, '09:30:00', '2019-05-15',	5.5),
(7, '17:00:00', '2019-05-15',	12.5),
(7, '09:30:00', '2019-05-16',	5.5),
(7, '17:00:00', '2019-05-16',	12.5)

GO
--INSERT TICKET INFO

INSERT Project.Ticket(ViewerId, ShowTimeId, PurchasedOn)
VALUES
(2, 58, '2019-11-15 12:07:46.000'),
(3, 72, '2019-11-16 13:45:42.000'),
(5, 1, '2019-11-09 16:35:41.000'),
(7, 58, '2019-11-15 09:49:11.000'),
(10, 86, '2019-11-17 09:37:44.000'),
(6, 115, '2019-08-16 14:15:02.000'),
(9, 114, '2019-08-17 06:07:45.000'),
(10, 115, '2019-08-16 16:52:46.000'),
(1, 116, '2019-08-16 22:46:33.000'),
(3, 60, '2019-11-14 18:24:08.000'),
(5, 88, '2019-11-17 03:10:39.000'),
(8, 60, '2019-11-14 22:51:25.000'),
(1, 63, '2019-11-15 03:01:57.000'),
(3, 7, '2019-11-10 16:36:21.000'),
(9, 92, '2019-11-17 10:22:27.000'),
(10, 79, '2019-11-15 17:02:33.000'),
(1, 53, '2019-11-14 16:58:10.000'),
(5, 25, '2019-11-12 14:29:06.000'),
(6, 24, '2019-11-12 12:12:50.000'),
(9, 96, '2019-11-17 08:53:21.000'),
(8, 40, '2019-11-13 13:03:33.000'),
(4, 26, '2019-11-12 05:20:39.000'),
(2, 40, '2019-11-12 22:50:38.000'),
(1, 120, '2019-05-16 11:34:28.000'),
(6, 118, '2019-05-15 10:30:29.000'),
(10, 41, '2019-11-13 03:41:44.000'),
(7, 56, '2019-11-14 16:16:38.000'),
(5, 27, '2019-11-10 08:31:23.000'),
(2, 27, '2019-11-10 09:38:52.000'),
(8, 83, '2019-11-16 03:23:38.000')

GO

