package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.ItemModel;

public interface ItemRepository extends CrudRepository<ItemModel, String> {

}
