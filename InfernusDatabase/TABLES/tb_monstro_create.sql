/* Script para criação da tabela o_inicio_do_fim_v2.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 25/05/2020 - Criação.

*/

USE infernus;

IF OBJECT_ID('dbo.tb_monstro') IS NOT NULL EXEC (
		'DROP TABLE [dbo].[tb_monstro];'
	)

CREATE TABLE tb_monstro
(
  id_monstro INT NOT NULL,
  nome VARCHAR(255) NOT NULL,
  tipo VARCHAR(255) NOT NULL,
  tamanho VARCHAR(255) NOT NULL,
  tendencia VARCHAR(255) NOT NULL,
  hp VARCHAR(255) NOT NULL,
  ca VARCHAR(255) NOT NULL,
  desloc_t VARCHAR(255) NOT NULL,
  desloc_e VARCHAR(255),
  desloc_n VARCHAR(255),
  desloc_v VARCHAR(255),
  desloc_s VARCHAR(255),
  bp VARCHAR(255) NOT NULL,
  stre VARCHAR(255) NOT NULL,
  dex VARCHAR(255) NOT NULL,
  con VARCHAR(255) NOT NULL,
  inte VARCHAR(255) NOT NULL,
  wis VARCHAR(255) NOT NULL,
  cha VARCHAR(255) NOT NULL,
  nd VARCHAR(255) NOT NULL,
  tracos TEXT NOT NULL,
  pericias TEXT NOT NULL,
  caracteristicas TEXT NOT NULL,
  acoes TEXT NOT NULL,
  acoeslendarias TEXT,
  PRIMARY KEY ( id_monstro )
);