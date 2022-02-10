package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.SkillModel;

public interface SkillRepository extends CrudRepository<SkillModel, String> {

}
