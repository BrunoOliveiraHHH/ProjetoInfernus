/* Script para criação da tabela infernus.tb_veiculo

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/11/2020 - Criação.

*/

USE infernus;

IF OBJECT_ID('dbo.tb_veiculo') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_veiculo]'
	)

CREATE TABLE tb_veiculo(
   id_veiculo  INT NOT NULL,
   nome  VARCHAR(255) NOT NULL,
   tipo  INT NOT NULL,
   custo  INT NOT NULL,
   moeda INT NOT NULL,
   velocidade  VARCHAR(255) NOT NULL,
   durabilidade INT NOT NULL
  PRIMARY KEY ( id_veiculo )
);

ALTER TABLE tb_veiculo
	ADD CONSTRAINT fk_tipo_veiculo
    FOREIGN KEY (tipo) 
    REFERENCES tb_tipo_veiculo (id_tipo_veiculo) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE tb_veiculo
	ADD CONSTRAINT fk_moeda_veiculo
    FOREIGN KEY (moeda) 
    REFERENCES tb_moeda (id_moeda) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE tb_veiculo
	ADD CONSTRAINT fk_durabilidade_veiculo 
    FOREIGN KEY (durabilidade) 
    REFERENCES tb_durabilidade (id_durabilidade) ON UPDATE CASCADE ON DELETE CASCADE;