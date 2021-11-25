package infernusJava.view;

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

	public void inserirArmdura(Armadura input) throws SQLException {

		_service.inserirArmdura(input);
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
