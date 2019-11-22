CREATE OR ALTER PROCEDURE Project.FetchViewer
	@ViewerId INT
AS
SELECT V.ViewerId, V.Gender, V.Email, V.BirthDate, V.Username, V.[Name]
FROM Project.Viewer V
WHERE V.ViewerId = @ViewerId;
GO