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
	IF OBJECT_ID('dbo.consulta_dropdown') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[consulta_dropdown]')
GO
	ALTER PROCEDURE consulta_dropdown
    @tipo INT    
AS

BEGIN
	
	BEGIN TRAN

    SET NOCOUNT ON

    IF(@tipo = 1)
        BEGIN
            SELECT id_tipo_armadura, nome FROM tb_tipo_armadura
        END
    ELSE IF(@tipo = 2)
		BEGIN
			SELECT id_durabilidade,descricao FROM tb_durabilidade
		END
	ELSE IF(@tipo = 3)
		BEGIN
			SELECT id_moeda,nome FROM tb_moeda
		END
	ELSE IF(@tipo = 4)
		BEGIN
			SELECT id_escola,nome FROM tb_escola_magia
		END
    ELSE IF(@tipo = 5)
		BEGIN
			SELECT nome FROM tb_tipo_monstro
		END
	ELSE IF(@tipo = 6)
		BEGIN
			SELECT nd,bp,XP FROM tb_nd_monstro
		END

    SET NOCOUNT OFF

	COMMIT TRAN

END