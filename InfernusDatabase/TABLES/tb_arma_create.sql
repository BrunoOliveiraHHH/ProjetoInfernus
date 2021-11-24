/* Script para criação da tabela infernus.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/10/2021 - Criação.
*/

USE infernus;

IF OBJECT_ID('dbo.tb_arma') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_arma]'
	)


CREATE TABLE tb_arma
(
  id_arma INT NOT NULL,
  nome VARCHAR(255) NOT NULL,
  custo INT NOT NULL,
  moeda INT NOT NULL,
  dano VARCHAR(255) NOT NULL,
  tipo_de_dano VARCHAR(255) NOT NULL,
  peso VARCHAR(255) NOT NULL,
  propriedade VARCHAR(255) NOT NULL,
  durabilidade INT NOT NULL,
  efeitos VARCHAR(255) NOT NULL,
  observacao VARCHAR(255) NOT NULL,
  PRIMARY KEY ( id_arma )
);

ALTER TABLE tb_arma
	ADD CONSTRAINT fk_durabilidade_arma
    FOREIGN KEY (durabilidade) 
    REFERENCES tb_durabilidade (id_durabilidade) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE tb_arma
	ADD CONSTRAINT fk_moeda_arma
    FOREIGN KEY (moeda) 
    REFERENCES tb_moeda (id_moeda) ON UPDATE CASCADE ON DELETE CASCADE;