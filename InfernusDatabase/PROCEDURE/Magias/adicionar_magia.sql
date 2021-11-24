/* Script para criação da PROCEDURE infernus.adicionar_magia
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 27/10/2021 - Criação.
 
 */
USE [infernus]
GO
	IF OBJECT_ID('dbo.adicionar_magia') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[adicionar_magia]  AS SET NOCOUNT ON;')
GO
	ALTER PROCEDURE adicionar_magia
  @nome VARCHAR(255),
  @nivel INT,
  @escola INT,
  @duracao VARCHAR(255),
  @alcance VARCHAR(255),
  @tempodeconjuracao VARCHAR(255),
  @componentes TEXT,
  @descricao TEXT
AS

BEGIN
    DECLARE @id_magia AS INT;
    DECLARE @total AS INT;

    SET @total = (select COUNT(*)
    from tb_magia WITH(NOLOCK));
    SET @id_magia = @total + 1;

    IF (@id_magia <> @total)
	    BEGIN
       INSERT INTO tb_magia ([id_magia] ,[nome] ,[nivel] ,[escola] ,[duracao] ,[alcance] ,[tempodeconjuracao] ,[componentes] ,[descricao])
     VALUES
           (@id_magia, @nome, @nivel, @escola, @duracao, @alcance, @tempodeconjuracao, @componentes, @descricao)
    END;
	IF(	SELECT COUNT(*)	FROM tb_magia WHERE id_magia = @id_magia) > 0
    	SELECT 1 AS 'Return'
	ELSE
    	SELECT 0 AS 'Return'
END;
GO
