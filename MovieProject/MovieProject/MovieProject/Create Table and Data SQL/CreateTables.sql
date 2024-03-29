IF SCHEMA_ID(N'Project') IS NULL
	EXEC(N'CREATE SCHEMA [Project];');
GO

DROP TABLE IF EXISTS Project.MovieActor;
DROP TABLE IF EXISTS Project.Actor;
DROP TABLE IF EXISTS Project.Ticket;
DROP TABLE IF EXISTS Project.Review;
DROP TABLE IF EXISTS Project.ShowTime;
DROP TABLE IF EXISTS Project.Viewer;
DROP TABLE IF EXISTS Project.Movie;
GO


CREATE TABLE Project.Movie 
(
	MovieId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL UNIQUE,
	Genre NVARCHAR(64) NOT NULL,
	Rating DECIMAL(2,1) NULL,
	Director NVARCHAR(64) NOT NULL,

	CHECK(Rating > 0 AND Rating <= 5)
);

CREATE TABLE Project.Viewer
(
	ViewerId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL,
	Gender NVARCHAR(32) NOT NULL,
	Email NVARCHAR(64) NOT NULL UNIQUE,
	BirthDate NVARCHAR(32) NOT NULL,
	Username NVARCHAR(32) NOT NULL
);


CREATE TABLE Project.ShowTime
(
	ShowTimeId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Project.Movie(MovieId),
	[Time] NVARCHAR(64) NOT NULL,
	[Date] NVARCHAR(64) NOT NULL,
	Price DECIMAL(4,2) NOT NULL
);

CREATE TABLE Project.Review
(
	ReviewId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Project.Movie(MovieId),
	ViewerId INT NOT NULL FOREIGN KEY
		REFERENCES Project.Viewer(ViewerId),
	ReviewMessage NVARCHAR(1024) NOT NULL,
	Rating DECIMAL(2,1) NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),

	CHECK(Rating > 0 AND Rating <= 5)
);

CREATE TABLE Project.Ticket
(
	TicketId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	ViewerId INT NOT NULL FOREIGN KEY
		REFERENCES Project.Viewer(ViewerId),
	ShowTimeId INT NOT NULL FOREIGN KEY
		REFERENCES Project.ShowTime(ShowTimeId),
	PurchasedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);


CREATE TABLE Project.Actor
(
	ActorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	[Name] NVARCHAR(128) NOT NULL UNIQUE
);

CREATE TABLE Project.MovieActor
(
	MovieActorId INT NOT NULL IDENTITY(1,1) PRIMARY KEY,
	MovieId INT NOT NULL FOREIGN KEY
		REFERENCES Project.Movie(MovieId),
	ActorId INT NOT NULL FOREIGN KEY
		REFERENCES Project.Actor(ActorId)
);
GO

