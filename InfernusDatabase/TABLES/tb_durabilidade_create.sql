/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE infernus;

CREATE TABLE tb_durabilidade
(
	id_durabilidade INT NOT NULL,
	descricao VARCHAR(255) NOT NULL,
	PRIMARY KEY (id_durabilidade)
);