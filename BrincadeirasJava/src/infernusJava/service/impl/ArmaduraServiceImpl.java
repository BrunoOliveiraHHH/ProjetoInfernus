package infernusJava.service.impl;

import java.sql.SQLException;
import java.util.List;

import infernusJava.dao.ArmaduraDAO;
import infernusJava.dao.impl.ArmaduraDAOImpl;
import infernusJava.models.Armadura;
import infernusJava.service.ArmaduraService;
import infernusJava.util.ValidacoesUtil;

public class ArmaduraServiceImpl implements ArmaduraService {

	private String jdbcURL;
	private String jdbcUsername;
	private String jdbcPassword;
	private ArmaduraDAO _dao;
	private ValidacoesUtil _util = null;

	public ArmaduraServiceImpl(String jdbcURL, String jdbcUsername, String jdbcPassword) {
		this.jdbcURL = jdbcURL;
		this.jdbcUsername = jdbcUsername;
		this.jdbcPassword = jdbcPassword;

	}

	@Override
	public List<Armadura> listAll() throws SQLException {

		_dao = new ArmaduraDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);

		return _dao.listAll();
	}

	@Override
	public boolean inserirArmdura(Armadura input) throws SQLException {

		_dao = new ArmaduraDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);
		_util = new ValidacoesUtil();

		if (!_util.validaCampoInteger(input.getId())) {
			return false;
		} else if (!_util.validaCampoString(input.getNome())) {
			return false;
		} else if (!_util.validaCampoString(input.getTipo())) {
			return false;
		} else if (!_util.validaCampoString(input.getCusto())) {
			return false;
		} else if (!_util.validaCampoString(input.getCa())) {
			return false;
		} else if (!_util.validaCampoString(input.getForca())) {
			return false;
		} else if (!_util.validaCampoString(input.getFurtv())) {
			return false;
		} else if (!_util.validaCampoString(input.getPeso())) {
			return false;
		} else if (!_util.validaCampoString(input.getObservacao())) {
			return false;
		} else {
			return _dao.inserirArmdura(input);
		}

	}

	@Override
	public boolean atualizarArmadura(Armadura input) throws SQLException {

		_dao = new ArmaduraDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);
		_util = new ValidacoesUtil();

		if (!_util.validaCampoInteger(input.getId())) {
			return false;
		} else if (!_util.validaCampoString(input.getNome())) {
			return false;
		} else if (!_util.validaCampoString(input.getTipo())) {
			return false;
		} else if (!_util.validaCampoString(input.getCusto())) {
			return false;
		} else if (!_util.validaCampoString(input.getCa())) {
			return false;
		} else if (!_util.validaCampoString(input.getForca())) {
			return false;
		} else if (!_util.validaCampoString(input.getFurtv())) {
			return false;
		} else if (!_util.validaCampoString(input.getPeso())) {
			return false;
		} else if (!_util.validaCampoString(input.getObservacao())) {
			return false;
		} else {
			return _dao.atualizarArmadura(input);
		}
	}

	@Override
	public boolean excluirArmadura(Armadura input) throws SQLException {

		_dao = new ArmaduraDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);
		_util = new ValidacoesUtil();

		if (!_util.validaCampoInteger(input.getId())) {
			return false;
		} else if (!_util.validaCampoString(input.getNome())) {
			return false;
		} else if (!_util.validaCampoString(input.getTipo())) {
			return false;
		} else if (!_util.validaCampoString(input.getCusto())) {
			return false;
		} else if (!_util.validaCampoString(input.getCa())) {
			return false;
		} else if (!_util.validaCampoString(input.getForca())) {
			return false;
		} else if (!_util.validaCampoString(input.getFurtv())) {
			return false;
		} else if (!_util.validaCampoString(input.getPeso())) {
			return false;
		} else if (!_util.validaCampoString(input.getObservacao())) {
			return false;
		} else {
			return _dao.excluirArmadura(input);
		}
	}

	@Override
	public Armadura buscarArmadura(Armadura input) throws SQLException {

		_dao = new ArmaduraDAOImpl(jdbcURL, jdbcUsername, jdbcPassword);
		_util = new ValidacoesUtil();

		if (!_util.validaCampoInteger(input.getId())) {
			return null;
		} else {
			return _dao.buscarArmadura(input);
		}
	}

}
