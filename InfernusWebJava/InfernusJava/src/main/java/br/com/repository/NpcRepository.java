package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.NpcModel;

public interface NpcRepository extends CrudRepository<NpcModel, String> {

}
