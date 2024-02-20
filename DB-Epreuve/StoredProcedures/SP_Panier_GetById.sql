CREATE PROCEDURE [dbo].[SP_Panier_GetById]
	@id_panier INT
AS
	SELECT	[Id_Panier],
			[Quantite],
			[Id_Produit],
			[Id_Commande]
		FROM [Panier]
		WHERE [Id_Panier] = @id_panier
