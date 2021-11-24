/* Script para criação da tabela infernus.tb_escola_magia

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 27/10/2021 - Criação.

*/

USE infernus;

IF OBJECT_ID('dbo.tb_escola_magia') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_escola_magia]'
	)

CREATE TABLE tb_escola_magia
(
	id_escola INT NOT NULL,
	nome VARCHAR(255) NOT NULL,
	PRIMARY KEY (id_escola)
);