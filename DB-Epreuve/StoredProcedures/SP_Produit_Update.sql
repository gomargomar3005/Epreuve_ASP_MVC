CREATE PROCEDURE [dbo].[SP_Produit_Update]
	@id_produit INT,
	@nom_produit NVARCHAR(100),
	@description NVARCHAR(500),
	@prix DECIMAL,
	@ecoscore NVARCHAR(10),
	@id_categorie INT
AS
	UPDATE [Produit]
		SET [Nom_Produit] = @nom_produit ,
			[Description] = @description ,
			[Prix] = @prix ,
			[EcoScore] = @ecoscore ,
			[Id_Categorie] = @id_categorie
		WHERE [Id_Produit] = @id_produit
