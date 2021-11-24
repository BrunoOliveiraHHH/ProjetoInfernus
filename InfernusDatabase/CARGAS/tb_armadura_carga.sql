/* Script para inserção de dados para a tabela infernus.tb_armadura

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 18/10/2021 - Criação.
/ Bruno Oliveira - 27/10/2021 - Adição do campo moeda e sua respectiva chave estrangeira.
*/

USE infernus;

INSERT INTO tb_armadura(id_armadura, nome, tipo, custo, moeda, ca, forca, furtv, peso, durabilidade, observacao) VALUES
	(1, 'Placas de Escamas de Dragão', 3, 15000, 4, '18', '15', 'Desvantagem', '32,5 Kg', 1, 'Possui Imunidade contra o tipo de dano do material'),
	(2, 'Mihtral', 3, 750, 4, '16', 'X', 'X', '27,5 Kg', 1, 'Uma cota de malha de mihtral não possui requerimento de força e não tem desvantagem em testes de furtividade'),
	(3, 'A Veste Negra', 1, 450, 4, '12+ mod. Des', 'X', 'Vantagem', '6,5 kg', 1, 'Na pernumbra ou o escuro o portador pode esconder usando uma ação bônus'),
	(4, 'Blood Plate', 3, 1000000, 5, '18', '15', 'X', '32,5 kg', 1, 'Aumenta a vida maxima do portador em 30 PV e concede imunidade contra danos criticos'),
	(5, 'Robe Vermelho', 4, 150000, 4, '13 + mod. Int', 'X', 'X', '1 Kg', 1, 'Imune a danos criticos'),
	(6, 'Escudo de Escama de Dragão', 5, 7500, 4, '+6', '15', 'Desvantagem', '16 Kg', 1, 'Possui Imunidade contra o tipo de dano do material'),
	(7, 'Escudo de Atena', 5, 1000000, 5, '+8', '18', 'Não-Desvantagem', '20', 1, 'O alvo que pode olhar para o rosto da medusa entalhado no bronze do escudo terá que realizar um Teste de Resistência de Sabedoria CD15 ou ficará amedrontado por 1 minuto.');
