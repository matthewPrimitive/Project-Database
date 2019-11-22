CREATE OR ALTER PROCEDURE Project.RetrieveViewerTicket
	@ViewerId INT
AS
SELECT T.TicketId, T.ViewerId, T.ShowTimeId, T.PurchasedOn
FROM Project.Ticket T
WHERE T.ViewerId = @ViewerId;
GO