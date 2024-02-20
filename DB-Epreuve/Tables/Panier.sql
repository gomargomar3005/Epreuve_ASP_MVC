CREATE TABLE [dbo].[Panier]
(
	[Id_Panier] INT NOT NULL PRIMARY KEY, 
    [Quantite] INT NOT NULL, 
    [Id_Produit] INT NOT NULL, 
    [Id_Commande] INT NOT NULL, 
    CONSTRAINT [FK_Panier_ToProduit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit])
)
