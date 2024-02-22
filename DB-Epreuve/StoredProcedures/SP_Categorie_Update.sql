CREATE PROCEDURE [dbo].[SP_Categorie_Update]
	@id_categorie INT,
	@produit_categorie NVARCHAR(50)
AS
	UPDATE [Categorie]
		SET [Produit_Categorie] = @produit_categorie
		WHERE [Id_Categorie] = @id_categorie
