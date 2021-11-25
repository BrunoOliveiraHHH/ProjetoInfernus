package infernusJava.util;

public class ValidacoesUtil {

	public ValidacoesUtil() {
	}

	public Boolean validaCampoString(String nome) {

		return nome.length() > 0;
	}

	public Boolean validaCampoInteger(int nome) {

		return nome > 0;

	}

}
