/* Script para criação da tabela infernus.tb_nd_monstro

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 16/11/2021 - Criação.

*/

USE infernus;

CREATE TABLE tb_nd_monstro
(
  id_nd_monstro INT NOT NULL,
  nd VARCHAR(255) NOT NULL,
  bp VARCHAR(255) NOT NULL,
  XP VARCHAR(255) NOT NULL
  PRIMARY KEY (id_nd_monstro)
);