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
