package javaSource.view;

import java.sql.SQLException;
import java.util.List;

import javaSource.models.ObjetoTeste;
import javaSource.service.TesteService;
import javaSource.service.impl.TesteServiceImpl;

public class TesteView {
	
	private String jdbcUrl = "jdbc:mysql://localhost:3306/teste";
	private String jdbcUsername = "root";
	private String jdbcPassword = "";
	private TesteService _service;
	
	public boolean inserirTeste(ObjetoTeste input) throws SQLException {
		
		_service = new TesteServiceImpl(jdbcUrl, jdbcUsername, jdbcPassword);
		
		return _service.inserirTeste(input);
		
	}

	public List<ObjetoTeste> listarTeste() throws SQLException {
		
		_service = new TesteServiceImpl(jdbcUrl, jdbcUsername, jdbcPassword);
		
		return _service.listarTeste();
	}
}
