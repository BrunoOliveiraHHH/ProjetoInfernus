/* Script para criação da PROCEDURE infernus.adiciona_arma
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 14/10/2021 - Criação.
 
 */
USE [infernus]
GO
	IF OBJECT_ID('dbo.adiciona_arma') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[adiciona_arma]  AS SET NOCOUNT ON;')
GO
	ALTER PROCEDURE [dbo].[adiciona_arma] 
	@nome VARCHAR(255),
	@custo INT,
	@moeda INT,
	@dano VARCHAR(255),
	@tipo_de_dano VARCHAR(255),
	@peso VARCHAR(255),
	@propriedade VARCHAR(255),
	@durabilidade INT,
	@efeitos VARCHAR(255),
	@observacao VARCHAR(255) 
	AS 
	
	DECLARE @id_arma AS INT 
	DECLARE @total AS INT

	BEGIN

	SET NOCOUNT ON

	SET @total = (select	COUNT(*) from tb_arma WITH(NOLOCK));

	SET @id_arma = @total + 1 ;

	IF (@id_arma <> @total)

    	INSERT INTO tb_arma (	[id_arma],	[nome],	[custo],	[moeda],	[dano],	[tipo_de_dano],	[peso],	[propriedade],	[durabilidade],	[efeitos],	[observacao])
     	 VALUES(	@id_arma,	@nome,	@custo,	@moeda,	@dano,	@tipo_de_dano,	@peso,	@propriedade,	@durabilidade,	@efeitos,	@observacao) 

	IF(	SELECT COUNT(*)	FROM tb_arma WHERE id_arma = @id_arma) > 0
    	SELECT 1 AS 'Return'
	ELSE
    	SELECT 0 AS 'Return'

	SET NOCOUNT OFF

	END