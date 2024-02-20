CREATE PROCEDURE [dbo].[SP_Image_Insert]
	@nom_image NVARCHAR(100),
	@url NVARCHAR(100),
	@id_produit INT
AS
	INSERT INTO [Image]([Nom_Image], [Url], [Id_Produit])
		OUTPUT [inserted].[Id_Image]
		VALUES (@nom_image, @url, @id_produit)