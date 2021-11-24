/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE consulta_veiculo_durabilidade
AS
BEGIN
	SELECT vei.nome as nome_veiculo,
		vei.tipo as tipo_veiculo,
		vei.custo as custo_veiculo,
		vei.velocidade as velocidade_maxima_veiculo,
		durab.descricao as status_durabilidade
	FROM [dbo].[tb_veiculo] AS vei
		INNER JOIN [dbo].[tb_durabilidade] AS durab ON vei.durabilidade = durab.id_durabilidade;
END;
GO
