CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
	@produit_categorie NVARCHAR(50)
AS
	INSERT INTO [Categorie] ([Produit_Categorie])
	OUTPUT [inserted].Id_Categorie
	VALUES (@produit_categorie)


    --code a essayer pour ajouter des categories mais voir avant si cela ne bloque pas la publication de la db

	-- CREATE PROCEDURE [dbo].[SP_Categorie_Insert]
    --@Nom_Categorie NVARCHAR(50)
--AS
--BEGIN
    -- Vérifier si la catégorie existe déjà
    --IF NOT EXISTS (SELECT 1 FROM Categorie WHERE Produit_Categorie = @Nom_Categorie)
    --BEGIN
        -- 
        --INSERT INTO [Categorie]([Produit_Categorie])
        --VALUES (@Nom_Categorie)
    --END
    --END
