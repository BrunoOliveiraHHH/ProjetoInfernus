package br.com.model;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotNull;

@Entity
public class AttachmentModel implements Serializable {

	private static final long serialVersionUID = -9096625573310351734L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long id_att;

	@NotNull
	private String nome;

	@NotNull
	private String custo;

	@NotNull
	private String peso;

	@NotNull
	private String tipo;

	@NotNull
	private String efeito;

	@NotNull
	private String observacao;

	public AttachmentModel() {

	}

	public Long getId_att() {
		return id_att;
	}

	public void setId_att(Long id_att) {
		this.id_att = id_att;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getCusto() {
		return custo;
	}

	public void setCusto(String custo) {
		this.custo = custo;
	}

	public String getPeso() {
		return peso;
	}

	public void setPeso(String peso) {
		this.peso = peso;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public String getEfeito() {
		return efeito;
	}

	public void setEfeito(String efeito) {
		this.efeito = efeito;
	}

	public String getObservacao() {
		return observacao;
	}

	public void setObservacao(String observacao) {
		this.observacao = observacao;
	}

}
