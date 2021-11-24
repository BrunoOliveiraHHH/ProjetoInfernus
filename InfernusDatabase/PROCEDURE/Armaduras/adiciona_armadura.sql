/* Script para criação da PROCEDURE infernus.adiciona_armadura
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 18/10/2021 - Criação.
 
 */
USE [infernus]
GO 
	SELECT GETDATE(), DB_NAME(), USER_NAME(), SUSER_NAME(), @@SERVERNAME
GO
	IF OBJECT_ID('dbo.adiciona_armadura') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[adiciona_armadura]')
GO
	ALTER PROCEDURE adiciona_armadura
    @nome VARCHAR(255),
    @tipo INT,
    @custo INT,
    @moeda INT,
	@ca VARCHAR(255),
    @furtv VARCHAR(255),
    @forca VARCHAR(255),
    @peso VARCHAR(255),
    @durabilidade 	INT,
    @observacao VARCHAR(255)
AS

    DECLARE @id_armadura AS INT;
    DECLARE @total AS INT;

BEGIN
	
	BEGIN TRAN

    SET NOCOUNT ON

    SET @total = (select COUNT(*) from tb_armadura WITH(NOLOCK));
    
    SET @id_armadura = @total + 1;

    IF (@id_armadura <> @total)
	    
    INSERT INTO tb_armadura ([id_armadura], [nome], [tipo], [custo], [moeda], [ca], [furtv], [forca], [peso], [durabilidade], [observacao])
     VALUES (@id_armadura, @nome, @tipo, @custo, @moeda, @ca, @furtv, @forca, @peso, @durabilidade, @observacao);
    
    IF( SELECT COUNT(*) FROM tb_armadura WHERE id_armadura = @id_armadura ) > 0        
        SELECT 1 AS 'Return'
	ELSE
        SELECT 0 AS 'Return'
    
    SET NOCOUNT OFF

	COMMIT TRAN

END