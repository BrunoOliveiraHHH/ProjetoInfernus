package javaSource.dao.impl;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import javaSource.dao.TesteDAO;
import javaSource.models.ObjetoTeste;

public class TesteDAOImpl implements TesteDAO{

	private String jdbcURL;
	private String jdbcUsername;
	private String jdbcPassword;
	private Connection jdbcConnection;

	public TesteDAOImpl(String jdbcURL, String jdbcUsername, String jdbcPassword) {
		this.jdbcURL = jdbcURL;
		this.jdbcUsername = jdbcUsername;
		this.jdbcPassword = jdbcPassword;
	}

	protected void connect() throws SQLException {
		if (jdbcConnection == null || jdbcConnection.isClosed()) {
			try {
				Class.forName("com.mysql.jdbc.Driver");
			} catch (ClassNotFoundException e) {
				throw new SQLException(e);
			}
			jdbcConnection = DriverManager.getConnection(jdbcURL, jdbcUsername, jdbcPassword);
		}
	}

	protected void disconnect() throws SQLException {
		if (jdbcConnection != null && !jdbcConnection.isClosed()) {
			jdbcConnection.close();
		}
	}
	
	@Override
	public boolean insertTeste(ObjetoTeste arma) throws SQLException {
		String sql = "INSERT INTO INSERIR_TESTE (id, nome, idade) VALUES (?,?,?)";

		connect();

		PreparedStatement statement = jdbcConnection.prepareStatement(sql);
		statement.setInt(1, arma.getId());
		statement.setString(2, arma.getNome());
		statement.setInt(3, arma.getIdade());

		boolean rowInserted = statement.executeUpdate() > 0;
		statement.close();
		disconnect();

		return rowInserted;
	}

	@Override
	public List<ObjetoTeste> listarTeste() throws SQLException {
		List<ObjetoTeste> listArma = new ArrayList<>();

		String sql = "SELECT id,nome,idade FROM INSERIR_TESTE";

		connect();
		
		Statement statement = jdbcConnection.createStatement();
		ResultSet resultSet = statement.executeQuery(sql);

		while (resultSet.next()) {
			int id = resultSet.getInt("id");
			String nome = resultSet.getString("nome");
			int idade = resultSet.getInt("idade");

			ObjetoTeste arma = new ObjetoTeste(id, nome, idade);

			listArma.add(arma);
		}
		
		resultSet.close();
		statement.close();
		
		disconnect();

		return listArma;
	}

}
