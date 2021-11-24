/* Script para inserção de dados para a tabela infernus.tb_magia

/----------- Modificações -----------------------------/
/ Nome           -   Data     - Descrição              /
/------------------------------------------------------/
/ Bruno Oliveira - 18/10/2021 - Criação.
/ Bruno Oliveira - 28/10/2021 - Alteração dos valores dos campos nivel,escola para inteiro conforme chave estrangeira.
*/

USE infernus;

INSERT INTO tb_magia (id_magia, nome, nivel, escola, duracao, alcance, tempodeconjuracao, componentes, descricao) VALUES
	(1, 'Exodo', 1, 3, 'Instantanea', '9 metros', '1 Ação', 'Verbal, Somatico, Material( uma pequena estatueta feita de barro ou madeira de Ápofis)', 'Um raio caótico de cor avermelhada chicoteia na direção de uma criatura dentro da area alvo. \r\nFaça um ataque á distancia com magia contra o alvo. Se atingir, o alvo sofrera 3d8 de dano de energia, caso role um 20 natural na jogada de ataque,não jogue o dobro de dados, mas o triplo no lugar. \r\nEm niveis superiores: Quando você conjurar essa magia no 2º nivel ou superior, o dano da magia aumenta em 1d8 para cada nivel de espaço acima do 1º'),
	(2, 'Ondas do Caos', 2, 3, 'Instantenea', 'Cone(4,5 metros)', '1 ação', 'Verbal, Somatico, Material( uma pequena estatueta feita de barro ou madeira de Ápofis)', 'Você estende sua mão em uma direção, uma onda de cor avermelhada surge a sua frente atingindo todas as criaturas na area alvo. Cada criatura na area alvo deve realizar um Teste de Resistencia de Destreza ou sofrera 5d8 de dano de energia. Caso obtenha sucesso, a criatura recebe metade do dano. Em niveis superiores: Quando você conjurar essa magia no 2º nivel ou superior, o dano da magia aumenta em 1d8 para cada nivel de espaço acima do 1º'),
	(3, 'As 10 Pragas do Egito', 5, 3, '1 ação', '18 metros', 'Instantanea', 'Verbal, Somatico, Material( uma pequena estatueta feita de barro ou madeira de Ápofis)', 'X');