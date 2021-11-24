/* Script para criação da tabela infernus.tb_tipo_veiculo

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/11/2021 - Criação.

*/

USE infernus;

CREATE TABLE tb_tipo_veiculo
(
  id_tipo_veiculo INT NOT NULL,
  nome VARCHAR(255) NOT NULL
  PRIMARY KEY (id_tipo_veiculo)
);