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

