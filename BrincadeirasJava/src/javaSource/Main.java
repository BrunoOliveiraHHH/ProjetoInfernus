package javaSource;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.SQLException;
import java.util.List;

import javaSource.models.ObjetoTeste;
import javaSource.view.TesteView;

public class Main {

	private static BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));
	private static ObjetoTeste objeto = new ObjetoTeste();

	public static void main(String[] args) {

		int possuiAinda = 2;
		int sair = 0;

		do {
			try {

				System.out.println("Escolha uma opção:");
				System.out.println("1 - Cadastrar");
				System.out.println("2 - Listar");
				System.out.println("3 - Fechar");

				int escolha = Integer.parseInt(reader.readLine());

				switch (escolha) {
				case 1:
					inserir();
					break;
				case 2:
					listar();
					break;
				default:
					sair = 3;
					possuiAinda = 2;
				}

				if (sair != 3) {

					System.out.println("Voltar?");
					System.out.println("1 - Sim");
					System.out.println("2 - Não");
					possuiAinda = Integer.parseInt(reader.readLine());
				}

			} catch (NumberFormatException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (IOException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			} catch (SQLException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} while (possuiAinda == 1);

	}

	private static void inserir() throws SQLException {

		try {
			TesteView _view = new TesteView();

			System.out.println("Informe um id:");
			objeto.setId(Integer.parseInt(reader.readLine()));
			System.out.println("Informe um nome:");
			objeto.setNome(reader.readLine());
			System.out.println("Informe uma idade:");
			objeto.setIdade(Integer.parseInt(reader.readLine()));

			boolean retorno = _view.inserirTeste(objeto);

			if (retorno) {
				System.out.println("Informações inseridas");
			} else {
				System.out.println("Informações não inseridas");
			}
		} catch (IOException e) {

			System.out.println(e.getMessage());
		} catch (SQLException e) {
			System.out.println(e.getMessage());
		}

	}

	private static void listar() throws SQLException {
		TesteView _view = new TesteView();

		List<ObjetoTeste> lista = _view.listarTeste();

		for (int i = 0; i < lista.size(); i++) {

			ObjetoTeste linha = lista.get(i);

			System.out.println(
					"Linha " + (i + 1) + ": " + linha.getId() + " - " + linha.getNome() + " - " + linha.getIdade());

		}
	}

}
