package javaSource.dao;

import java.sql.SQLException;
import java.util.List;

import javaSource.models.ObjetoTeste;

public interface TesteDAO {

	public boolean insertTeste(ObjetoTeste arma) throws SQLException;
	
	public List<ObjetoTeste> listarTeste() throws SQLException;
	
}
