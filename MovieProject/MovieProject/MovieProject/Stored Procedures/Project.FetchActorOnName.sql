CREATE OR ALTER PROCEDURE Project.FetchActorOnName
	@Name NVARCHAR(128)
AS
SELECT A.ActorId, A.[Name]
FROM Project.Actor A
WHERE A.[Name] = @Name;
GO