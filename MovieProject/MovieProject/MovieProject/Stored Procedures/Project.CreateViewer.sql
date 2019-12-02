CREATE OR ALTER PROCEDURE Project.CreateViewer
	@Name NVARCHAR,
	@Gender NVARCHAR,
	@Email NVARCHAR,
	@BirthDate DATE,
	@Username NVARCHAR,
	@ViewerId INT OUTPUT
AS
INSERT Project.Viewer([Name], Gender, Email, BirthDate, Username)
VALUES (@Name, @Gender, @Email, @BirthDate, @Username)

SET @ViewerId = SCOPE_IDENTITY();
GO