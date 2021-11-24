/* Script para criação da carga do objeto infernus.tb_mensagens

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/10/2021 - Criação.
/ Bruno Oliveira - 24/10/2021 - Adição dos cod_msg's 110,111,112,113.
/ Bruno Oliveira - 27/10/2021 - Adição dos cod_msg's 114 à 120 e o 999
*/

USE infernus;

BEGIN TRAN

DELETE FROM tb_mensagens

COMMIT TRAN

EXEC inserir_mensagens 100, 'O campo "nome" é obrigatório.';
EXEC inserir_mensagens 101, 'O campo "custo" é obrigatório.';
EXEC inserir_mensagens 102, 'O campo "moeda" é obrigatório.';
EXEC inserir_mensagens 103, 'O campo "dano" é obrigatório.';
EXEC inserir_mensagens 104, 'O campo "tipo_de_dano" é obrigatório.';
EXEC inserir_mensagens 105, 'O campo "obrigatório" é obrigatório.';
EXEC inserir_mensagens 106, 'O campo "propriedade" é obrigatório.';
EXEC inserir_mensagens 107, 'O campo "durabilidade" é obrigatório.';
EXEC inserir_mensagens 108, 'O campo "efeitos" é obrigatório.';
EXEC inserir_mensagens 109, 'O campo "observacao" é obrigatório.';
EXEC inserir_mensagens 110, 'O campo "ca" é obrigatório.';
EXEC inserir_mensagens 111, 'O campo "furtividade" é obrigatório.';
EXEC inserir_mensagens 112, 'O campo "forca" é obrigatório.';
EXEC inserir_mensagens 113, 'O campo "tipo_armadura" é obrigatório.';
EXEC inserir_mensagens 114, 'O campo "descricao" é obrigatório.';
EXEC inserir_mensagens 115, 'O campo "nivel" é obrigatório.';
EXEC inserir_mensagens 116, 'O campo "escola" é obrigatório.';
EXEC inserir_mensagens 117, 'O campo "duracao" é obrigatório.';
EXEC inserir_mensagens 118, 'O campo "alcance" é obrigatório.';
EXEC inserir_mensagens 119, 'O campo "tempo_de_conjuracao" é obrigatório.';
EXEC inserir_mensagens 120, 'O campo "componentes" é obrigatório.';
EXEC inserir_mensagens 121, 'O campo "{0}" é obrigatório.';


EXEC inserir_mensagens 999, 'Sem objeto para preenchimento, favor validar novamente.';