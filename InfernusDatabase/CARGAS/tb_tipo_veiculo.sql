/* Script para inserção de dados para a tabela infernus.tb_tipo_armadura

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/11/2021 - Criação.
*/

USE infernus;

INSERT INTO  tb_tipo_veiculo
	( id_tipo_veiculo, nome)
VALUES
	(1, 'Aquático'),
	(2, 'Aéreo'),
	(3, 'Terrestre'),
	(4, 'Subterrâneo'),
	(5, 'Subaquático'),
	(6, 'Outros');