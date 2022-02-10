package br.com.repository;

import org.springframework.data.repository.CrudRepository;

import br.com.model.AttachmentModel;

public interface AttachmentRepository extends CrudRepository <AttachmentModel, String>{

}
