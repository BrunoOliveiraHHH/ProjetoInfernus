/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE ler_item_por_id
    @id_item INT
AS
BEGIN
	SELECT item.id_item as ID,
        item.nome as nome_item,
		item.custo as custo_item,
		item.peso as peso_item,
		item.descricao as descricao_item,
		durab.descricao as status_durabilidade
	FROM [dbo].[tb_item] AS item
		INNER JOIN [dbo].[tb_durabilidade] AS durab ON item.durabilidade = durab.id_durabilidade
    WHERE id_item = @id_item
END;
GO
