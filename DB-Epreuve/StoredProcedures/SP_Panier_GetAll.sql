CREATE PROCEDURE [dbo].[SP_Panier_GetAll]
AS
	SELECT	[Id_Panier],
			[Quantite],
			[Id_Produit],
			[Id_Commande]
	FROM [Panier]
