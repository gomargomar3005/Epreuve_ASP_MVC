/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

INSERT INTO [Categorie]
    VALUES  ('Hygiène'),
            ('Jardin'),
            ('Décoration'),
            ('Textile'),
            ('Mobilier');
GO

EXEC SP_Produit_Insert 'Savon de Marseille', 'Un savon qui fait partir des tâches et qui fait éventuellement sentir bon. Et en plus il est bio.', '2.00', 'A', '1' ;