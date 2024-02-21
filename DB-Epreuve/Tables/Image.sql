CREATE TABLE [dbo].[Image]
(
	[Id_Image] INT NOT NULL IDENTITY PRIMARY KEY, 
    [Nom_Image] NVARCHAR(100) NOT NULL, 
    [Url] NVARCHAR(100) NOT NULL, 
    [Id_Produit] INT NOT NULL, 
    CONSTRAINT [FK_Image_ToProduit] FOREIGN KEY ([Id_Produit]) REFERENCES [Produit]([Id_Produit])
)
