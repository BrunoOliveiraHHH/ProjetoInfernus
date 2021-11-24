/* Script para criação da PROCEDURE infernus.consulta_arma
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 25/10/2021 - Criação.
 
 */
USE [infernus]
GO
	IF OBJECT_ID('dbo.consulta_arma') IS NULL 
	EXEC ('CREATE PROCEDURE consulta_arma  AS SET NOCOUNT ON;')
GO
	ALTER PROCEDURE consulta_arma 
	AS

	BEGIN

	SET NOCOUNT ON

	SELECT arm.id_arma as ID, 
		arm.nome,
		arm.custo,
		moeda.nome as moeda,
		arm.dano,
		arm.tipo_de_dano,
		arm.peso,
		arm.propriedade,
		dub.descricao as durabiliade,
		arm.observacao
	FROM [dbo].[tb_arma] AS arm
		INNER JOIN [dbo].[tb_moeda] AS moeda ON arm.moeda = moeda.id_moeda
		INNER JOIN [dbo].[tb_durabilidade] AS dub ON arm.durabilidade = dub.id_durabilidade;

	SET NOCOUNT OFF

	END