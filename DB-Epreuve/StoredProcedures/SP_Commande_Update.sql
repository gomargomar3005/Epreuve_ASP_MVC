CREATE PROCEDURE [dbo].[SP_Commande_Update]
	@id_commande INT,
	@date_commande DATETIME
AS
	UPDATE [Commande]
		SET [Date_Commande] = @date_commande
		WHERE [Id_Commande] = @id_commande
