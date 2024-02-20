CREATE PROCEDURE [dbo].[SP_Image_Update]
	@id_image INT,
	@nom_image NVARCHAR(100),
	@url NVARCHAR(100),
	@id_produit INT
AS
	UPDATE [Image]
		SET [Nom_Image] = @nom_image ,
			[Url] = @url ,
			[Id_Produit] = @id_produit
		WHERE [Id_Image] = @id_image
