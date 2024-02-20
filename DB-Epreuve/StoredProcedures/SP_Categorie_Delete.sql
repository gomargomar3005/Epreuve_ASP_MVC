CREATE PROCEDURE [dbo].[SP_Categorie_Delete]
	@id_categorie INT
AS
	DELETE FROM [Categorie]
		WHERE [Id_Categorie] = @id_categorie
