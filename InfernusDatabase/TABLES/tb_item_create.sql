/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.
/ Bruno Oliveira - 27/10/2021 - Adição do campo moeda e sua respectiva chave estrangeira.
*/

USE infernus;

IF OBJECT_ID('dbo.tb_item') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_item]'
	)

CREATE TABLE tb_item
(
  id_item INT NOT NULL,
  nome VARCHAR(255) NOT NULL,
  custo INT NOT NULL,
  moeda INT NOT NULL,
  peso VARCHAR(255) NOT NULL,
  durabilidade INT NOT NULL,
  descricao TEXT,
  PRIMARY KEY ( id_item )
);


ALTER TABLE tb_item
	ADD CONSTRAINT fk_durabilidade_item 
    FOREIGN KEY (durabilidade) 
    REFERENCES tb_durabilidade (id_durabilidade) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE tb_item
	ADD CONSTRAINT fk_moeda_item
    FOREIGN KEY (moeda) 
    REFERENCES tb_moeda (id_moeda) ON UPDATE CASCADE ON DELETE CASCADE;