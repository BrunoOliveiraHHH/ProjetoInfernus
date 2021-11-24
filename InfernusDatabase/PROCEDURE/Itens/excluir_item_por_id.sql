/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE excluir_item_por_id
    @id_item INT
AS
BEGIN
	DELETE FROM [dbo].[tb_item] 
    WHERE id_item = @id_item
END;
GO
