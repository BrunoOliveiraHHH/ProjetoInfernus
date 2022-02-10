package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.ArmaduraModel;

public interface ArmaduraRepository extends CrudRepository<ArmaduraModel, String> {

}