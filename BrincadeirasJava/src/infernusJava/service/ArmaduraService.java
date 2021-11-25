package infernusJava.service;

import java.sql.SQLException;
import java.util.List;

import infernusJava.models.Armadura;

public interface ArmaduraService {

	public List<Armadura> listAll() throws SQLException;

	public boolean inserirArmdura(Armadura input) throws SQLException;

	public boolean atualizarArmadura(Armadura input) throws SQLException;

	public boolean excluirArmadura(Armadura input) throws SQLException;

	public Armadura buscarArmadura(Armadura input) throws SQLException;

}
