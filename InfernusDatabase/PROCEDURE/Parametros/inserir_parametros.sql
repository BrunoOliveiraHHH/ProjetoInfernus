/* Script para criação da PROCEDURE infernus.inserir_parametros
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 04/10/2021 - Criação.
 
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

IF OBJECT_ID('dbo.inserir_parametros') IS NULL
	EXEC ('CREATE PROCEDURE [dbo].[inserir_parametros] AS SET NOCOUNT ON;')
GO

ALTER PROCEDURE inserir_parametros
@nom_parametro VARCHAR(255),
@des_parametro VARCHAR(500)
AS

DECLARE @id_parametro AS INT;
    DECLARE @total AS INT;
BEGIN

SET NOCOUNT ON

    SET @total = (select COUNT(*)
    from [dbo].[tb_parametro]);
    SET @id_parametro = @total + 1;


    IF (@id_parametro <> @total)
    BEGIN
        INSERT INTO  tb_parametro
            ( id_parametro, nom_parametro, des_parametro, dat_atualizacao )
        VALUES
            (@id_parametro, @nom_parametro, @des_parametro, getDate())
    END

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