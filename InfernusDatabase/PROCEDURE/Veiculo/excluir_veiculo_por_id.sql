/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE excluir_veiculo_por_id
    @id_veiculo INT
AS
BEGIN
	DELETE FROM [dbo].[tb_veiculo] 
    WHERE id_veiculo = @id_veiculo;
END;
GO
