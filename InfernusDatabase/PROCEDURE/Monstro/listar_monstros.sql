/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE listar_monstro
AS
BEGIN
    SELECT id_monstro, 
        nome,
        tipo,
        tamanho,
        tendencia,
        hp,
        ca,
        desloc_t,
        desloc_e,
        desloc_n,
        desloc_v,
        desloc_s,
        bp,
        stre,
        dex,
        con,
        inte,
        wis,
        cha,
        nd,
        tracos,
        caracteristicas,
        acoes,
        acoeslendarias
    FROM [dbo].[tb_monstro];
END;
GO