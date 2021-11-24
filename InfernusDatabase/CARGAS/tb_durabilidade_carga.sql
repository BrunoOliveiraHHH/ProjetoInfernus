/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE infernus;

INSERT INTO tb_durabilidade
    (id_durabilidade, descricao)
VALUES
    (1, 'Completo'),
    (2, '3/4'),
    (3, 'Meio'),
    (4, '1/4'),
    (5, 'Quebrado'),
    (6, 'Destruído');