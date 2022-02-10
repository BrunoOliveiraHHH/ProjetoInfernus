package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.ArmaModel;

public interface ArmaRepository extends CrudRepository<ArmaModel, String> {

}
