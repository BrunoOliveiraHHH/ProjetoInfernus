/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE infernus;

CREATE TABLE tb_parametro
(
  id_parametro INT NOT NULL,
  nom_parametro VARCHAR(255) NOT NULL,
  des_parametro VARCHAR(500) NOT NULL,
  dat_atualizacao DATETIME NOT NULL,
  PRIMARY KEY ( id_parametro )
);