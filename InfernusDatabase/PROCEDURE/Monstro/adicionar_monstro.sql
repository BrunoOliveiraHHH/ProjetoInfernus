/* Script para criação da PROCEDURE infernus.adicionar_monstro
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 12/11/2021 - Criação.
 
 */
USE [infernus]
GO
	IF OBJECT_ID('dbo.adicionar_monstro') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[adicionar_monstro]  AS SET NOCOUNT ON;')
GO
	ALTER PROCEDURE adicionar_monstro
  @nome VARCHAR(255),
  @tipo VARCHAR(255),
  @tamanho VARCHAR(255),
  @tendencia VARCHAR(255),
  @hp VARCHAR(255),
  @ca VARCHAR(255),
  @desloc_t VARCHAR(255),
  @desloc_e VARCHAR(255),
  @desloc_n VARCHAR(255),
  @desloc_v VARCHAR(255),
  @desloc_s VARCHAR(255),
  @bp VARCHAR(255),
  @stre VARCHAR(255),
  @dex VARCHAR(255),
  @con VARCHAR(255),
  @inte VARCHAR(255),
  @wis VARCHAR(255),
  @cha VARCHAR(255),
  @nd VARCHAR(255),
  @tracos TEXT,
  @pericias TEXT,
  @caracteristicas TEXT,
  @acoes TEXT,
  @acoeslendarias TEXT
AS

BEGIN
    DECLARE @id_monstro AS INT;
    DECLARE @total AS INT;

    SET @total = (select COUNT(*)
    from [dbo].[tb_monstro]);
    SET @id_monstro = @total + 1;

    IF (@id_monstro <> @total)
	    BEGIN
        INSERT INTO [dbo].[tb_monstro]
           ([id_monstro] ,[nome] ,[tipo] ,[tamanho] ,[tendencia] ,[hp] ,[ca] ,
           [desloc_t] ,[desloc_e] ,[desloc_n] ,[desloc_v] ,[desloc_s] ,[bp] ,[stre] ,
           [dex] ,[con] ,[inte] ,[wis] ,[cha] ,[nd] ,[tracos] ,[pericias] ,[caracteristicas] ,
           [acoes] ,[acoeslendarias])
     VALUES
           (@id_monstro , @nome, @tipo, @tamanho, @tendencia, @hp, @ca,
            @desloc_t, @desloc_e, @desloc_n, @desloc_v, @desloc_s, @bp,
             @stre, @dex, @con, @inte, @wis, @cha, @nd, @tracos, @pericias,
              @caracteristicas, @acoes, @acoeslendarias)
    END;

    IF(	SELECT COUNT(*)	FROM tb_monstro WHERE id_monstro = @id_monstro) > 0
    	SELECT 1 AS 'Return'
	ELSE
    	SELECT 0 AS 'Return'
END;
GO
