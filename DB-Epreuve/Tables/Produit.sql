CREATE TABLE [dbo].[Produit]
(
	[Id_Produit] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Nom_Produit] NVARCHAR(100) NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [Prix] MONEY NOT NULL, 
    [EcoScore] NCHAR(10) NOT NULL, 
    [Id_Categorie] INT NOT NULL, 
    CONSTRAINT [FK_Produit_ToCategorie] FOREIGN KEY ([Id_Categorie]) REFERENCES [Categorie]([Id_Categorie]),

    CONSTRAINT [CK_Produit_Prix] CHECK ([Prix] > 0)
)
