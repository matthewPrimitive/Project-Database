CREATE OR ALTER PROCEDURE Project.FetchTicket
	@TicketId INT
AS
SELECT T.TicketId, T.ViewerId, T.ShowTimeId, T.PurchasedOn
FROM Project.Ticket T
WHERE T.TicketId = @TicketId;
GO