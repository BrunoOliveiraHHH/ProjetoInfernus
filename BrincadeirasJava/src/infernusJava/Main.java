package infernusJava;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.sql.SQLException;

import infernusJava.view.ArmaduraView;

public class Main {

	private static ArmaduraView _viewArmor = new ArmaduraView();
	private static BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

	public static void main(String[] args) {

		int possuiAinda = 2;
		int sair = 0;

		do {
			try {
				System.out.println("Escolha uma opção:");
				System.out.println("1 - Armaduras");
				System.out.println("0 - Sair");

				int escolha = Integer.parseInt(reader.readLine());

				switch (escolha) {
				case 1:
					menuArmor();
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
			}
		} while (possuiAinda == 1);

	}

	private static void menuArmor() {
		try {
			System.out.println("Menu Armadura");
			System.out.println("1 - Listar");
			System.out.println("2 - Voltar");
			int escolha = Integer.parseInt(reader.readLine());
			
			switch (escolha) {
			case 1:
				_viewArmor.listAll();
				break;
			default:
				break;
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

	}

}
