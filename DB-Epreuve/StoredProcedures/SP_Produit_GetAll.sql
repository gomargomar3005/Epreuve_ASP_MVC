CREATE PROCEDURE [dbo].[SP_Produit_GetAll]
AS
	SELECT [Id_Produit],
	[Nom_Produit],
	[Description],
	[Prix],
	[EcoScore],
	[Id_Categorie]
	FROM [Produit]
