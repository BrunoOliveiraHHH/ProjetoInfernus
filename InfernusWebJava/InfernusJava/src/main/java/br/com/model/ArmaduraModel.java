package br.com.model;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotNull;

@Entity
public class ArmaduraModel implements Serializable {

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long id_armadura;
	
	@NotNull
	private String nome;
	@NotNull
	private String tipo;
	@NotNull
	private String custo;
	@NotNull
	private String ca;
	@NotNull
	private String furtv;
	@NotNull
	private String forca;
	@NotNull
	private String peso;
	
	@Column (columnDefinition="TEXT")
	private String observacao;

	public ArmaduraModel() {

	}

	public Long getId_Armadura() {
		return id_armadura;
	}

	public void setId_Armadura(Long id_armadura) {
		this.id_armadura = id_armadura;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getTipo() {
		return tipo;
	}

	public void setTipo(String tipo) {
		this.tipo = tipo;
	}

	public String getCusto() {
		return custo;
	}

	public void setCusto(String custo) {
		this.custo = custo;
	}

	public String getCa() {
		return ca;
	}

	public void setCa(String ca) {
		this.ca = ca;
	}

	public String getFurtv() {
		return furtv;
	}

	public void setFurtv(String furtv) {
		this.furtv = furtv;
	}

	public String getForca() {
		return forca;
	}

	public void setForca(String forca) {
		this.forca = forca;
	}

	public String getPeso() {
		return peso;
	}

	public void setPeso(String peso) {
		this.peso = peso;
	}

	public String getObservacao() {
		return observacao;
	}

	public void setObservacao(String observacao) {
		this.observacao = observacao;
	}

}