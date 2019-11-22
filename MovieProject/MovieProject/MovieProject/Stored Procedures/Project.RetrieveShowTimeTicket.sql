CREATE OR ALTER PROCEDURE Project.RetrieveShowTimeTicket
	@ShowTimeId INT
AS
SELECT T.TicketId, T.ViewerId, T.ShowTimeId, T.PurchasedOn
FROM Project.Ticket T
WHERE T.ShowTimeId = @ShowTimeId;
GO