/* Script para criação da PROCEDURE infernus.consultar_parametro
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 04/10/2021 - Criação.
 
 */
USE [infernus]
GO
	BEGIN TRAN
GO
SELECT
	GETDATE(),
	DB_NAME(),
	USER_NAME(),
	SUSER_NAME(),
	@@SERVERNAME
GO
	IF OBJECT_ID('dbo.consultar_mensagens') IS NULL EXEC (
		'CREATE PROCEDURE [dbo].[consultar_mensagens] AS SET NOCOUNT ON;'
	)
GO
	ALTER PROCEDURE consultar_mensagens
    @cod_msg INT
    AS
    BEGIN
SET
	NOCOUNT ON
SELECT
	cod_msg,
	des_msg
FROM
	[dbo].[tb_mensagens]
WHERE
	cod_msg = @cod_msg;

SET
	NOCOUNT OFF
END
GO
	COMMIT TRAN
GO
	IF @@trancount <> 0 BEGIN DECLARE @MENSAGEM VARCHAR(100)
SET
	@MENSAGEM = 'ERRO DE TRANSAÇÕES - EXISTE(M) ' + CAST(@@TRANCOUNT AS VARCHAR(9)) + ' BEGIN(S) A MAIS NO SCRIPT' ROLLBACK TRAN RAISERROR (@MENSAGEM, 16, 1)
END
ELSE
SELECT
	GETDATE(),
	DB_NAME(),
	USER_NAME(),
	SUSER_NAME(),
	@@SERVERNAME