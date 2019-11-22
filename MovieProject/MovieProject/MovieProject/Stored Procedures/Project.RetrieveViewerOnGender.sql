CREATE OR ALTER PROCEDURE Project.RetrieveViewerOnGender
	@Gender NVARCHAR(32)
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.Gender = @Gender;
GO