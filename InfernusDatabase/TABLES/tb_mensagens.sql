/* Script para criação da tabela infernus.tb_mensagens

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/10/2021 - Criação.

*/

USE infernus;

IF OBJECT_ID('dbo.tb_mensagens') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_mensagens] AS SET NOCOUNT ON;'
	)


CREATE TABLE tb_mensagens
(
  cod_msg INT NOT NULL,
  des_msg VARCHAR(255) NOT NULL,
  dat_insercao DATETIME NOT NULL,
  PRIMARY KEY ( cod_msg )
);