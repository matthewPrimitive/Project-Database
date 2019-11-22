CREATE OR ALTER PROCEDURE Project.FetchActor
	@ActorId INT
AS
SELECT A.ActorId, A.[Name]
FROM Project.Actor A
WHERE A.ActorId = @ActorId;
GO