CREATE PROCEDURE [dbo].[SP_Categorie_GetAll]
AS
	SELECT [Id_Categorie],
	[Produit_Categorie]
	FROM [Categorie]