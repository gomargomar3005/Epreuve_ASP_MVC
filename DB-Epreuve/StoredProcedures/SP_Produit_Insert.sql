CREATE PROCEDURE [dbo].[SP_Produit_Insert]
	@nom_produit NVARCHAR(100),
	@description NVARCHAR(500),
	@prix DECIMAL,
	@ecoscore NVARCHAR(10),
	@id_categorie INT
AS
	INSERT INTO [Produit] ([Nom_Produit], [Description], [Prix], [EcoScore], [Id_Categorie])
		OUTPUT [inserted].[Id_Produit]
		VALUES (@nom_produit, @description, @prix, @ecoscore, @id_categorie)
