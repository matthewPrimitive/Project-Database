CREATE OR ALTER PROCEDURE Project.RetrieveViewerOnEmail
	@Email NVARCHAR(128)
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.Email = @Email;
GO