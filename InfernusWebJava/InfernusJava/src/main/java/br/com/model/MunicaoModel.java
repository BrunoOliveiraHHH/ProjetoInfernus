package br.com.model;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotNull;

@Entity
public class MunicaoModel implements Serializable {

	private static final long serialVersionUID = 4879431083316742747L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long id_muni;

	@NotNull
	private String calibre;

	@NotNull
	private String quantidade;

	@NotNull
	private String custo;

	@NotNull
	private String peso;

	@NotNull
	private String armas;

	@NotNull
	private String nome;
	
	private String observacao;

	public MunicaoModel() {

	}

	public Long getId_muni() {
		return id_muni;
	}

	public void setId_muni(Long id_muni) {
		this.id_muni = id_muni;
	}

	public String getCalibre() {
		return calibre;
	}

	public void setCalibre(String calibre) {
		this.calibre = calibre;
	}

	public String getQuantidade() {
		return quantidade;
	}

	public void setQuantidade(String quantidade) {
		this.quantidade = quantidade;
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

	public String getArmas() {
		return armas;
	}

	public void setArmas(String armas) {
		this.armas = armas;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getObservacao() {
		return observacao;
	}

	public void setObservacao(String observacao) {
		this.observacao = observacao;
	}
}
