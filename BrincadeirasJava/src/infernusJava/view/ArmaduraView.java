package infernusJava.view;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.SQLException;
import java.util.List;

import infernusJava.models.Armadura;
import infernusJava.service.ArmaduraService;
import infernusJava.service.impl.ArmaduraServiceImpl;

public class ArmaduraView {

	private static String jdbcUrl = "jdbc:mysql://localhost:3306/meurpg";
	private static String jdbcUsername = "root";
	private static String jdbcPassword = "";
	private static ArmaduraService _service;
	private static BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

	public ArmaduraView() {

	}

	public void listAll() throws SQLException {

		_service = new ArmaduraServiceImpl(jdbcUrl, jdbcUsername, jdbcPassword);

		List<Armadura> lista = _service.listAll();

		for (int i = 0; i < lista.size(); i++) {

			Armadura linha = lista.get(i);

			System.out.println(linha.toString());

		}
	}

	public void inserirArmdura() throws SQLException, IOException {

		Armadura input = null;

		System.out.println("Digite o nome do item: ");
		String nome = reader.readLine();
		System.out.println("Digite o tipo de armadura: ");
		String tipo = reader.readLine();
		System.out.println("Digite o custo do item: ");
		String custo = reader.readLine();
		System.out.println("Digite a CA da armadura: ");
		String ca = reader.readLine();
		System.out.println("Digite a força necessaria: ");
		String forca = reader.readLine();
		System.out.println("Digite a furtividade: ");
		String furtv = reader.readLine();
		System.out.println("Digite o peso do item:");
		String peso = reader.readLine();
		System.out.println("Digite as observações adicionais: ");
		String observacao = reader.readLine();

		input = new Armadura(1, nome, tipo, custo, ca, forca, furtv, peso, observacao);

		boolean retorno = _service.inserirArmdura(input);

		if (retorno) {
			System.out.println("Informações inseridas.");
		} else {
			System.out.println("Erro ao inserir, favor verificar os dados informados.");
		}
	}

	public void atualizarArmadura(Armadura input) throws SQLException {

		_service.atualizarArmadura(input);
	}

	public void excluirArmadura(Armadura input) throws SQLException {

		_service.excluirArmadura(input);
	}

	public void buscarArmadura(Armadura input) throws SQLException {

		_service.buscarArmadura(input);
	}

}
