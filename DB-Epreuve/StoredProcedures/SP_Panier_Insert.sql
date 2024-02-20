CREATE PROCEDURE [dbo].[SP_Panier_Insert]
	@quantite INT,
	@id_produit INT,
	@id_commande INT
AS
	INSERT INTO [Panier] ([Quantite], [Id_Produit], [Id_Commande])
		OUTPUT [inserted].[Id_Panier]
		VALUES (@quantite, @id_produit, @id_commande)
