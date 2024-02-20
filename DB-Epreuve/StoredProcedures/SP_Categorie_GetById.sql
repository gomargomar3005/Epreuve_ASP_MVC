CREATE PROCEDURE [dbo].[SP_Categorie_GetById]
	@id_categorie INT
AS
	SELECT [Id_Categorie],
	[Produit_Categorie]
	FROM [Categorie]
	WHERE [Id_Categorie] = @id_categorie