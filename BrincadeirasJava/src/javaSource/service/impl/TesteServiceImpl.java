package javaSource.service.impl;

import java.sql.SQLException;
import java.util.List;

import javaSource.dao.TesteDAO;
import javaSource.dao.impl.TesteDAOImpl;
import javaSource.models.ObjetoTeste;
import javaSource.service.TesteService;

public class TesteServiceImpl implements TesteService {

	private String jdbcURL;
	private String jdbcUsername;
	private String jdbcPassword;
	private TesteDAO _dao;

	public TesteServiceImpl(String jdbcURL, String jdbcUsername, String jdbcPassword) {
		this.jdbcURL = jdbcURL;
		this.jdbcUsername = jdbcUsername;
		this.jdbcPassword = jdbcPassword;
	}

	@Override
	public boolean inserirTeste(ObjetoTeste input) throws SQLException {

		_dao = new TesteDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);

		boolean retorno = false;

		if (!validaCampoString(input.getNome())) {
			
			return retorno;
			
		} else if (!validaCampoInteger(input.getId()) && !validaCampoInteger(input.getIdade())) {
			
			return retorno;
			
		} else {
			
			retorno = _dao.insertTeste(input);

			return retorno;
		}
	}

	@Override
	public List<ObjetoTeste> listarTeste() throws SQLException {
		
		_dao = new TesteDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);

		return _dao.listarTeste();
	}

	private Boolean validaCampoString(String nome) {
		
		return nome.length() > 0;
		
	}

	private Boolean validaCampoInteger(int nome) {
		
		return nome > 0;
		
	}

}
