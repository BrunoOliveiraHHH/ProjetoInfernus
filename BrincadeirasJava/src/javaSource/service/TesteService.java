package javaSource.service;

import java.sql.SQLException;
import java.util.List;

import javaSource.models.ObjetoTeste;

public interface TesteService {

	public boolean inserirTeste(ObjetoTeste input) throws SQLException;
	
	public List<ObjetoTeste> listarTeste() throws SQLException;
}
