/* Script para criação da carga do objeto infernus.tb_mensagens

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 14/10/2021 - Criação.
/ Bruno Oliveira - 27/10/2021 - Adição de parametros sqlConString,procedureAdicionarItem e procedureAdicionarMagia
*/

USE infernus;

BEGIN TRAN

DELETE FROM tb_parametro

COMMIT TRAN

EXEC inserir_parametros 'procedureListarDurabilidade', 'EXECUTE [dbo].[listar_durabilidades]';
EXEC inserir_parametros 'procedureConsultarUsuario', 'EXECUTE [dbo].[consultar_usuario]';
EXEC inserir_parametros 'ListaBtnMenu','ArmaMuniON';
EXEC inserir_parametros 'ListaBtnMenu','ArmaduraON';
EXEC inserir_parametros 'ListaBtnMenu','VeiculoON';
EXEC inserir_parametros 'ListaBtnMenu','ItemON';
EXEC inserir_parametros 'ListaBtnMenu','MonstroON';
EXEC inserir_parametros 'procedureConsultaArmaMunicao', 'EXECUTE [dbo].[consulta_arma_municao]';
EXEC inserir_parametros 'procedureListaMuniIdNome', 'EXECUTE [dbo].[listar_nome_id_municao]';
EXEC inserir_parametros 'procedureAdicionarArma','EXECUTE [dbo].[adiciona_arma]';
EXEC inserir_parametros 'procedureExcluirArma','EXECUTE [dbo].[excluir_arma_por_id]';
EXEC inserir_parametros 'procedurePesquisarArma','EXECUTE [dbo].[ler_arma_por_id]';
EXEC inserir_parametros 'procedureAdicionarArmadura','EXECUTE [dbo].[adiciona_armadura]';
EXEC inserir_parametros 'procedureConsultaDropdown','EXECUTE [dbo].[consulta_dropdown]';
EXEC inserir_parametros 'sqLConString','Data Source=CPX-8EQCRI78XQ5\SQLEXPRESS;Initial Catalog=infernus;Integrated Security=True;';
EXEC inserir_parametros 'procedureAdicionarItem','EXECUTE [dbo].[adicionar_item]';
EXEC inserir_parametros 'procedureAdicionarMagia','EXECUTE [dbo].[adicionar_magia]';
EXEC inserir_parametros 'procedureAdicionarMonstro','EXECUTE [dbo].[adicionar_monstro]';
EXEC inserir_parametros 'procedureAdicionarVeiculos','EXECUTE [dbo].[adicionar_veiculo]';
EXEC inserir_parametros 'ItemUnico','1';