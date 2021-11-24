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
	@ @SERVERNAME
GO
	IF OBJECT_ID('dbo.consultar_parametro') IS NULL EXEC (
		'CREATE PROCEDURE [dbo].[consultar_parametro] AS SET NOCOUNT ON;'
	)
GO
	ALTER PROCEDURE consultar_parametro 
	@nom_parametro VARCHAR(255) 
	AS 
	BEGIN
SET
	NOCOUNT ON
SELECT
	des_parametro
FROM
	[dbo].[tb_parametro]
WHERE
	nom_parametro = @nom_parametro;

SET
	NOCOUNT OFF
END
GO
	COMMIT TRAN
GO
	IF @ @trancount <> 0 BEGIN DECLARE @MENSAGEM VARCHAR(100)
SET
	@MENSAGEM = 'ERRO DE TRANSAÇÕES - EXISTE(M) ' + CAST(@ @TRANCOUNT AS VARCHAR(9)) + ' BEGIN(S) A MAIS NO SCRIPT' ROLLBACK TRAN RAISERROR (@MENSAGEM, 16, 1)
END
ELSE
SELECT
	GETDATE(),
	DB_NAME(),
	USER_NAME(),
	SUSER_NAME(),
	@ @SERVERNAME