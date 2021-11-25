package infernusJava.dao.impl;

import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.ArrayList;
import java.util.List;

import infernusJava.dao.ArmaduraDAO;
import infernusJava.models.Armadura;

public class ArmaduraDAOImpl implements ArmaduraDAO {

	private String jdbcURL;
	private String jdbcUsername;
	private String jdbcPassword;
	private Connection jdbcConnection;

	public ArmaduraDAOImpl(String jdbcURL, String jdbcUsername, String jdbcPassword) {
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
	public List<Armadura> listAll() throws SQLException {
		List<Armadura> listaArmadura = new ArrayList<>();

		String sql = "SELECT * FROM armadura_model";

		connect();

		Statement statement = jdbcConnection.createStatement();
		ResultSet resultSet = statement.executeQuery(sql);

		while (resultSet.next()) {

			int id = resultSet.getInt("id_armadura");
			String nome = resultSet.getString("nome");
			String tipo = resultSet.getString("tipo");
			String custo = resultSet.getString("custo");
			String ca = resultSet.getString("ca");
			String forca = resultSet.getString("forca");
			String furtv = resultSet.getString("furtv");
			String peso = resultSet.getString("peso");
			String observacao = resultSet.getString("observacao");

			Armadura arma = new Armadura(id, nome, tipo, custo, ca, forca, furtv, peso, observacao);

			listaArmadura.add(arma);
		}

		resultSet.close();
		statement.close();

		disconnect();

		return listaArmadura;
	}

	@Override
	public boolean inserirArmdura(Armadura input) throws SQLException {
		String sql = "INSERT INTO armadura_model (id_armadura, nome, tipo, custo, ca, forca, furtv, peso, observacao) VALUES(?,?,?,?,?,?,?,?,?)";

		connect();

		PreparedStatement statement = jdbcConnection.prepareStatement(sql);
		statement.setInt(1, input.getId());
		statement.setString(2, input.getNome());
		statement.setString(3, input.getTipo());
		statement.setString(4, input.getCusto());
		statement.setString(5, input.getCa());
		statement.setString(6, input.getForca());
		statement.setString(7, input.getFurtv());
		statement.setString(8, input.getPeso());
		statement.setString(9, input.getObservacao());

		boolean linhaInserida = statement.executeUpdate() > 0;
		statement.close();
		disconnect();

		return linhaInserida;
	}

	@Override
	public boolean atualizarArmadura(Armadura input) throws SQLException {
		String sql = "UPDATE armadura_model SET nome = ?, tipo = ?, custo = ?, ca = ?, forca = ?, furtv = ?, peso = ?, observacao = ?";
		sql += " WHERE id_armadura = ?";
		connect();

		PreparedStatement statement = jdbcConnection.prepareStatement(sql);
		statement.setString(1, input.getNome());
		statement.setString(2, input.getTipo());
		statement.setString(3, input.getCusto());
		statement.setString(4, input.getCa());
		statement.setString(5, input.getForca());
		statement.setString(6, input.getFurtv());
		statement.setString(7, input.getPeso());
		statement.setString(8, input.getObservacao());
		statement.setInt(9, input.getId());

		boolean linhaAtualizada = statement.executeUpdate() > 0;
		statement.close();
		disconnect();

		return linhaAtualizada;
	}

	@Override
	public boolean excluirArmadura(Armadura input) throws SQLException {
		String sql = "DELETE FROM armadura_model WHERE id_armadura = ?";

		connect();

		PreparedStatement statement = jdbcConnection.prepareStatement(sql);
		statement.setInt(1, input.getId());

		boolean linhaExcluida = statement.executeUpdate() > 0;
		statement.close();
		disconnect();

		return linhaExcluida;
	}

	@Override
	public Armadura buscarArmadura(Armadura input) throws SQLException {
		Armadura armadura = null;

		String sql = "SELECT * FROM armadura_model";
		sql += " WHERE id_armadura = ?";

		connect();

		PreparedStatement statement = jdbcConnection.prepareStatement(sql);
		statement.setInt(1, input.getId());
		ResultSet resultSet = statement.executeQuery(sql);

		while (resultSet.next()) {

			int id = input.getId();
			String nome = resultSet.getString("nome");
			String tipo = resultSet.getString("tipo");
			String custo = resultSet.getString("custo");
			String ca = resultSet.getString("ca");
			String forca = resultSet.getString("forca");
			String furtv = resultSet.getString("furtv");
			String peso = resultSet.getString("peso");
			String observacao = resultSet.getString("observacao");

			armadura = new Armadura(id, nome, tipo, custo, ca, forca, furtv, peso, observacao);
		}

		resultSet.close();
		statement.close();

		disconnect();

		return armadura;
	}

}
