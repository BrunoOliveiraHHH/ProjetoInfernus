package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.MonstroModel;

public interface MonstroRepository extends CrudRepository<MonstroModel, String> {

}
