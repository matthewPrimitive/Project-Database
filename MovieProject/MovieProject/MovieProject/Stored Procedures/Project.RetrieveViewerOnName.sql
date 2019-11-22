CREATE OR ALTER PROCEDURE Project.RetrieveViewerOnName
	@Name NVARCHAR(128)
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.[Name] = @Name;
GO