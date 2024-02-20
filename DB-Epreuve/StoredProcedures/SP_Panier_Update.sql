CREATE PROCEDURE [dbo].[SP_Panier_Update]
	@id_panier INT,
	@quantite INT,
	@id_produit INT,
	@id_commande INT
AS
	UPDATE [Panier]
		SET [Quantite] = @quantite ,
			[Id_Produit] = @id_produit ,
			[Id_Commande] = @id_commande
		WHERE [Id_Panier] = @id_panier
