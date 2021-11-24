/* Script para criação da tabela infernus.tb_armadura

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/10/2021 - Criação.
/ Bruno Oliveira - 27/10/2021 - Adição do campo moeda e sua respectiva chave estrangeira.
*/

USE infernus;

IF OBJECT_ID('dbo.tb_armadura') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_armadura]'
	)

CREATE TABLE tb_armadura
(
  id_armadura INT NOT NULL,
  nome VARCHAR(255) NOT NULL,
  tipo INT NOT NULL,
  custo INT NOT NULL,
  moeda INT NOT NULL,
  ca VARCHAR(255) NOT NULL,
  furtv VARCHAR(255) NOT NULL,
  forca VARCHAR(255) NOT NULL,
  peso VARCHAR(255) NOT NULL,
  durabilidade INT NOT NULL,
  observacao TEXT,
  PRIMARY KEY (id_armadura)
);


ALTER TABLE tb_armadura
	ADD CONSTRAINT fk_durabilidade_armadura 
    FOREIGN KEY (durabilidade) 
    REFERENCES tb_durabilidade (id_durabilidade) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE tb_armadura
	ADD CONSTRAINT fk_tipo_armadura 
    FOREIGN KEY (tipo) 
    REFERENCES tb_tipo_armadura (id_tipo_armadura) ON UPDATE CASCADE ON DELETE CASCADE;

ALTER TABLE tb_armadura
	ADD CONSTRAINT fk_moeda_armadura
    FOREIGN KEY (moeda) 
    REFERENCES tb_moeda (id_moeda) ON UPDATE CASCADE ON DELETE CASCADE;