/* Script para criação da PROCEDURE infernus.adiciona_item
 
 /----------- Modificaçães -----------------------------/
 / Nome           -   Data     - Descrição              /
 /------------------------------------------------------/
 / Bruno Oliveira - 27/10/2021 - Criação.
 
 */
USE [infernus]
GO
	IF OBJECT_ID('dbo.adicionar_item') IS NULL EXEC 
	('CREATE PROCEDURE [dbo].[adicionar_item]  AS SET NOCOUNT ON;')
GO
	ALTER PROCEDURE adicionar_item
  @nome VARCHAR(255),
  @custo INT,
  @moeda INT,
  @peso VARCHAR(255),
  @durabilidade INT,
  @descricao TEXT
AS

BEGIN
    DECLARE @id_item AS INT;
    DECLARE @total AS INT;

    SET @total = (select COUNT(*)
    from tb_item WITH(NOLOCK));
    SET @id_item = @total + 1;

    IF (@id_item <> @total)
	    BEGIN
        INSERT INTO  tb_item
            (id_item, nome, custo, moeda, peso, durabilidade, descricao)
        VALUES
            (@id_item, @nome, @custo, @moeda, @peso, @durabilidade, @descricao);
    END;

    IF(	SELECT COUNT(*)	FROM tb_item WHERE id_item = @id_item) > 0
    	SELECT 1 AS 'Return'
	ELSE
    	SELECT 0 AS 'Return'
END;
GO
