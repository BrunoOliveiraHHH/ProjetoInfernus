package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.MunicaoModel;

public interface MunicaoRepository extends CrudRepository<MunicaoModel, String> {

}