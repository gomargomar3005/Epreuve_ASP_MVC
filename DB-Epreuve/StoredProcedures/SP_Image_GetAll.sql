CREATE PROCEDURE [dbo].[SP_Image_GetAll]
AS
	SELECT [Id_Image],
	[Nom_Image],
	[Url],
	[Id_Produit]
	FROM [Image]
