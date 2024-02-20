CREATE PROCEDURE [dbo].[SP_Panier_Delete]
	@id_panier INT
AS
	DELETE FROM [Panier]
		WHERE [Id_Panier] = @id_panier
