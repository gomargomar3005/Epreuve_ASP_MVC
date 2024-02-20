CREATE PROCEDURE [dbo].[SP_Image_Delete]
	@id_image INT,
	@nom_image NVARCHAR(100),
	@url NVARCHAR(100),
	@id_produit INT
AS
	DELETE FROM [Image]
		WHERE [Id_Image] = @id_image
