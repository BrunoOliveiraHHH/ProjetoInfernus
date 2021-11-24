/* Script para criação da PROCEDURE infernus.inserir_mensagens
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 14/10/2021 - Criação.
 
 */
USE [infernus]
GO

BEGIN TRAN
GO

SELECT GETDATE()
	, DB_NAME()
	, USER_NAME()
	, SUSER_NAME()
	, @@SERVERNAME
GO

IF OBJECT_ID('dbo.inserir_mensagens') IS NULL
	EXEC ('CREATE PROCEDURE [dbo].[inserir_mensagens] AS SET NOCOUNT ON;')
GO

ALTER PROCEDURE inserir_mensagens
@cod_msg VARCHAR(255),
@des_msg VARCHAR(255)
AS

BEGIN

SET NOCOUNT ON

    INSERT INTO  tb_mensagens
        (cod_msg, des_msg, dat_insercao)
    VALUES
        (@cod_msg, @des_msg, getDate())

SET NOCOUNT OFF
END
GO

COMMIT TRAN
GO

IF @@trancount <> 0
BEGIN
	DECLARE @MENSAGEM VARCHAR(100)

	SET @MENSAGEM = 'ERRO DE TRANSAÇÕES - EXISTE(M) ' + CAST(@@TRANCOUNT AS VARCHAR(9)) + ' BEGIN(S) A MAIS NO SCRIPT'

	ROLLBACK TRAN

	RAISERROR (@MENSAGEM, 16, 1)
END
ELSE
	SELECT GETDATE()
		, DB_NAME()
		, USER_NAME()
		, SUSER_NAME()
		, @@SERVERNAME