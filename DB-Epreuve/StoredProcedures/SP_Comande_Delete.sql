CREATE PROCEDURE [dbo].[SP_Comande_Delete]
	@id_commande INT
AS
	DELETE FROM [Commande]
		WHERE [Id_Commande] = @id_commande
