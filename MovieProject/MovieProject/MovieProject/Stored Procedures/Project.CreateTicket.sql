CREATE OR ALTER PROCEDURE Project.CreateTicket
	@ViewerId INT,
	@ShowTimeId INT,
	@TicketId INT OUTPUT
AS
INSERT Project.Ticket(ViewerId, ShowTimeId)
VALUES (@ViewerId, @ShowTimeId)

SET @TicketId = SCOPE_IDENTITY();
GO