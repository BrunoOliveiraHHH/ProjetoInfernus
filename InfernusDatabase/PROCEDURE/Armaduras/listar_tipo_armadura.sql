/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE o_inicio_do_fim_v2;
GO

CREATE PROCEDURE listar_tipo_armadura
AS
BEGIN
    SELECT id_tipo_armadura,
            nome
    FROM [dbo].[tb_tipo_armadura];
END;
GO