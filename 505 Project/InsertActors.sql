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

