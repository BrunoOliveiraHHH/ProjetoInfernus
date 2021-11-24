/* Script para inserção de dados para a tabela infernus.tb_tipo_armadura

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 18/10/2021 - Criação.
*/

USE infernus;

INSERT INTO  tb_tipo_armadura
	( id_tipo_armadura, nome)
VALUES
	(1, 'Armaduras Leves'),
	(2, 'Armaduras Medias'),
	(3, 'Armaduras Pesadas'),
	(4, 'Túnicas'),
	(5, 'Escudos'),
	(6, 'Outros');