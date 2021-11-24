/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE excluir_armadura_por_id
    @id_armadura INT
AS
BEGIN
	DELETE FROM [dbo].[tb_armadura]
    WHERE id_armadura = @id_armadura
END;
GO
