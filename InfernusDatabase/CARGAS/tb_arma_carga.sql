/* Script para inserção de dados para a tabela infernus.tb_arma

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 18/10/2021 - Criação.
/ Bruno Oliveira - 25/10/2021 - Troca do valor do campo moeda por inteiro conforme chave estrangeira da tabela

*/

USE infernus;

INSERT INTO tb_arma(id_arma, nome, custo, moeda, dano, tipo_de_dano, peso, propriedade, durabilidade, efeitos, observacao) VALUES
	(1, 'Excalibur', 75000, 4, '1d8+2', 'Cortante Mágico', '1,5 kg', 'Versátil(1d10)', 1, '3d8 Radiante Extra contra Mortos-Vivos e Corruptores', 'Arma Marcial Corpo-a-Corpo'),
	(2, 'Agulha Negra', 10000, 4, '1d8+1', 'Perfurante Mágico', '1 Kg', 'Acuidade', 1, '3d8 Necrótico Extra', 'Arma Marcial Corpo-a-Corpo'),
	(3, 'Lua Crescente', 15000, 4, '1d8+1', 'Cortante Mágico', '1,5 kg', 'Versátil(1d10), Acuidade', 1, '1d8 Extra contra Criaturas da Noite', 'Arma Marcial Corpo-a-Corpo'),
	(4, 'Senhora do Olimpo', 1000000, 5, '4d6+3', 'Cortante Mágico', '3 Kg', 'Pesada, Duas-Mãos', 1, 'Retira Divindade contra Celestiais', 'Arma Marcial Corpo-a-Corpo'),
	(5, 'Senhor do Olimpo', 1000000, 5, '4d6+3', 'Cortante Mágico', '3 Kg', 'Pesada, Duas-Mãos', 1, 'Retira Imortalidade', 'Arma Marcial Corpo-a-Corpo'),
	(6, 'Mjonir', 1000000, 5, '1d12+3', 'Concussão Mágico', '3,5 Kg', '-', 1, '4d8 Trovejante Extra', 'Arma Marcial Corpo-a-Corpo'),
	(7, 'Arco de Tífon', 1000000, 5, '1d8+2', 'Perfurante Mágico', '1 kg', 'Munição (distância 45/180), Pesada, Duas mãos', 1, '2d8 Frio Extra', 'Armas Marciais à Distância'),
	(8, 'Arco Lunar', 1000000, 5, '2d8+3', 'Perfurante Mágico', '1 kg', 'Munição (distância 45/180), pesada, duas mãos', 1, 'não possui desvantagem por distância, 2d8 Fogo extra', 'Armas Marciais à Distância'),
	(9, 'Lança do Destino', 1000000, 5, '2d10+3', 'Radiante', '4 kg', 'Pesada, alcance, duas mãos', 1, 'todos os ataques tem vantagem', 'Armas Marcial Corpo-a-Corpo'),
	(10, 'Vingador Sangrento', 20000, 4, '1d8+2', 'Cortante Mágico', '2 Kg', 'Versátil(1d10)', 1, 'Recupera 1d8+2 por golpe acertado', 'Armas Marcial Corpo-a-Corpo'),
	(11, 'Tridente de Poseidon', 1000000, 5, '4d6+3', 'Frio', '2 Kg', 'Arremesso (6/18), versátil (4d8)', 1, 'O portador fica sob o efeito da magia "respirar na agua" enquanto portar o tridente', 'Armas Marcial Corpo-a-Corpo'),
	(12, 'Lamina dos Mil Demonios', 1000000, 5, '2d8+3', 'Necrotico', '1,5 Kg', 'Versátil(d10)', 1, ' Pode prender a alma do alvo caso o alvo morra pela lamina dos mil demonios', 'Arma Marcial Corpo-a-Corpo'),
	(13, 'Espada Adamantina', 25000, 4, '2d8+1', 'Cortante Mágico', '1,5 kg', '-', 1, 'Ataques com vantagem tem dano critico', 'Arma Marcial Corpo-a-Corpo'),
	(14, 'Bahgtru', 5000, 4, '2d6', 'Perfurante', '0,5 Kg', '-', 1, 'O Dano da arma é adicionado ao dano de um ataque desarmado', 'Arma Simples Corpo-a-Corpo'),
	(15, 'Motzeu', 1500, 4, '1d10+1', 'Necrótico', '4 kg', '-', 1, 'O portador fica sobre o efeito da magia "falar com os mortos"', 'Armas Marcial Corpo-a-Corpo'),
	(16, 'Son Wukong', 5000, 4, '1d6+2', 'Concussão Mágico', '2 kg', 'Versatil(1d8)', 1, 'O bastão permite fazer dois ataques em um unico turno(não conta como ação extra) e adiciona o bônus da arma aos testes de Destreza(Acrobacia)', 'Arma Simples Corpo-a-Corpo'),
	(17, 'Hofund', 1000000, 5, '4d6+3', 'Cortante Mágico', '3 kg', 'Pesada, Duas Mãos', 1, 'Concede visão verdadeira (3m) ao portador, vantagem em testes de Sabedoria(Percepção)', 'Arma Marcial Corpo-a-Corpo'),
	(18, 'Kataware-doki', 1000000, 5, '1d10+4', 'Radiante/Necrótico', '1,5 Kg', 'Versátil(d12)', 1, 'O dano muda conforme o horário do dia, de dia o dano é radiante, durante a noite é necrótico.', 'Arma Marcial Corpo-a-Corpo'),
	(19, 'Chaos', 1000000, 5, '3d8+3', 'Cortante Mágico', '1,5 Kg', 'Versátil(3d10)', 1, 'o portador fica imortal enquanto empunhar a arma.', 'Arma Marcial Corpo-a-Corpo'),
	(20, 'Kar Balerin', 10000, 4, '4d4+3', 'Frio', '0,5 Kg', 'Ágil, leve, arremesso (6/18)', 1, 'O alvo atingindo  faz um teste de constituição CD15, se falhar fica congelado. Em um acerto crítico o alvo falha automaticamente.', 'Arma Simples Corpo-a-Corpo'),
	(21, 'Gargauth', 10000, 4, '2d4+2', 'Perfurante Mágico', '0,5 Kg', 'Ágil, leve, arremesso (6/18)', 1, ' o portador pode teletransportar para o local da adaga por uma quantidade de vezes igual ao mod.INT+1 do portador.', 'Arma Simples Corpo-a-Corpo'),
	(22, 'Ghal Marraz', 1000000, 5, '1d12+3', 'Radiante', '3,5 Kg', '-', 1, 'Emite luz num raio de 9m(6quad.).', 'Armas Marcial Corpo-a-Corpo'),
	(23, 'Morning Star', 20000, 4, '2d8', 'Radiante', '2 Kg', '-', 1, '3d8 Radiante Extra contra Mortos-Vivos e Corruptores', 'Arma Marcial Corpo-a-Corpo'),
	(24, 'Martelo Cruzado', 10000, 4, '1d8+1', 'Radiante', '2 Kg', '-', 1, '1d8 Radiante Extra contra Mortos-Vivos e Corruptores', 'Armas Marcial Corpo-a-Corpo');