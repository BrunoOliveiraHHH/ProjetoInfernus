/* Script para criação da tabela infernus.tb_tipo_monstro

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 16/11/2021 - Criação.
/ Bruno Oliveira - 16/11/2021 - Alteração do tipo do campo descricao de varchar para text.

*/

USE infernus;

IF OBJECT_ID('dbo.tb_tipo_monstro') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_tipo_monstro]'
	)

CREATE TABLE tb_tipo_monstro
(
  id_tipo_monstro INT NOT NULL,
  nome VARCHAR(255) NOT NULL,
  descricao TEXT NOT NULL
  PRIMARY KEY (id_tipo_monstro)
);