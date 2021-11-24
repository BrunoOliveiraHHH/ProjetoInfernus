/* Script para criação da tabela infernus.tb_magia

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 18/10/2020 - Criação.

*/

USE infernus;

IF OBJECT_ID('dbo.tb_magia') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_magia]'
	)

CREATE TABLE tb_magia (
  id_magia int NOT NULL,
  nome varchar(255) NOT NULL,
  nivel INT NOT NULL,
  escola INT NOT NULL,
  duracao varchar(255) NOT NULL,
  alcance varchar(255) NOT NULL,
  tempodeconjuracao varchar(255) NOT NULL,
  componentes text NOT NULL,
  descricao text NOT NULL,
  PRIMARY KEY (id_magia)
);


ALTER TABLE tb_magia
	ADD CONSTRAINT fk_escola_magia
    FOREIGN KEY (escola) 
    REFERENCES tb_escola_magia (id_escola) ON UPDATE CASCADE ON DELETE CASCADE;