/* Script para criação da tabela infernus.tb_moeda

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 24/10/2021 - Criação.

*/

USE infernus;

CREATE TABLE tb_moeda
(
	id_moeda INT NOT NULL,
	nome VARCHAR(255) NOT NULL,
	PRIMARY KEY (id_moeda)
);