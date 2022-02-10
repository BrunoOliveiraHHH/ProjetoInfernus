package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.VeiculoModel;

public interface VeiculoRepository extends CrudRepository<VeiculoModel, String> {

}