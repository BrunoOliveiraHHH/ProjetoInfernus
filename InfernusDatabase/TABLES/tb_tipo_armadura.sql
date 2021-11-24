/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE infernus;

CREATE TABLE tb_tipo_armadura
(
  id_tipo_armadura INT NOT NULL,
  nome VARCHAR(255) NOT NULL
  PRIMARY KEY (id_tipo_armadura)
);