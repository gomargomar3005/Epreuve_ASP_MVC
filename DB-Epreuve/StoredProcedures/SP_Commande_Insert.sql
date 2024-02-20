CREATE PROCEDURE [dbo].[SP_Commande_Insert]
	@date_commande DATETIME
AS
	INSERT INTO [Commande] ([Date_Commande])
		OUTPUT [inserted].[Id_Commande]
		VALUES (@date_commande)
