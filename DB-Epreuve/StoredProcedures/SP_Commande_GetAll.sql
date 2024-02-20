CREATE PROCEDURE [dbo].[SP_Commande_GetAll]
AS
	SELECT	[Id_Commande],
			[Date_Commande]
		FROM [Commande]
