CREATE PROCEDURE [dbo].[SP_Image_GetById]
	@id_image INT
AS
	SELECT [Id_Image],
	[Nom_Image],
	[Url],
	[Id_Produit]
	FROM [Image]
	WHERE [Id_Image] = @id_image