/* Script para criação da PROCEDURE infernus.adicionar_veiculo
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 14/11/2021 - Criação.
 */

USE infernus;
GO
	IF OBJECT_ID('dbo.adicionar_veiculo') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[adicionar_veiculo]  AS SET NOCOUNT ON;')
GO
	ALTER PROCEDURE adicionar_veiculo
	@nome VARCHAR(255),
	@tipo VARCHAR(255),
	@custo INT,
	@moeda INT,
	@velocidade VARCHAR(255),
	@durabilidade INT
AS
BEGIN
	DECLARE @id_veiculo AS INT;
	DECLARE @total AS INT;
	SET @total = (select COUNT(*)
	from [dbo].[tb_veiculo]);
	SET @id_veiculo = @total + 1;

	IF (@id_veiculo <> @total)
	        BEGIN
		INSERT INTO  [dbo].[tb_veiculo]
			(id_veiculo, nome, tipo, custo, moeda, velocidade, durabilidade)
		VALUES
			(@id_veiculo, @nome, @tipo, @custo, @moeda, @velocidade, @durabilidade);
	END;

	IF(	SELECT COUNT(*)	FROM tb_veiculo WHERE id_veiculo = @id_veiculo) > 0
    	SELECT 1 AS 'Return'
	ELSE
    	SELECT 0 AS 'Return'
END;
GO
