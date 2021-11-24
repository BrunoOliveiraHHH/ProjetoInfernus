/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE ler_arma_por_id
	@id_arma INT
AS
BEGIN
	SELECT arm.id_arma as ID,
		arm.nome as nome_arma,
		arm.custo as custo_arma,
		arm.dano as dano_arma,
		arm.tipo_de_dano as tipo_de_dano_arma,
		arm.peso as peso_arma,
		arm.propriedade as propriedade_arma,
		muni.nome as nome_municao,
		muni.custo as custo_municao,
		muni.calibre as calibre_municao,
		muni.quantidade as quantidade_municao,
		muni.observacao as observacao_municao,
		dub.descricao as durabiliade_arma,
		arm.observacao as observacao_arma
	FROM [dbo].[tb_arma] AS arm
		INNER JOIN [dbo].[tb_municao] AS muni ON arm.municao = muni.id_municao
		INNER JOIN [dbo].[tb_durabilidade] AS dub ON arm.durabilidade = dub.id_durabilidade
	WHERE id_arma = @id_arma;
END;
GO
