package br.com.model;

import java.io.Serializable;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotNull;

@Entity
public class ArmaModel implements Serializable {

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long id_arma;
	
	@NotNull
	private String nome;
	@NotNull
	private String custo;
	@NotNull
	private String dano;
	@NotNull
	private String tipoDeDano;
	@NotNull
	private String peso;
	@NotNull
	private String propriedade;
	@NotNull
	private String observacao;

	public ArmaModel() {

	}

	public Long getId_Arma() {
		return id_arma;
	}

	public void setId_Arma(Long id_arma) {
		this.id_arma = id_arma;
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

	public String getDano() {
		return dano;
	}

	public void setDano(String dano) {
		this.dano = dano;
	}

	public String getTipoDeDano() {
		return tipoDeDano;
	}

	public void setTipoDeDano(String tipoDeDano) {
		this.tipoDeDano = tipoDeDano;
	}

	public String getPeso() {
		return peso;
	}

	public void setPeso(String peso) {
		this.peso = peso;
	}

	public String getPropriedade() {
		return propriedade;
	}

	public void setPropriedade(String propriedade) {
		this.propriedade = propriedade;
	}

	public String getObservacao() {
		return observacao;
	}

	public void setObservacao(String observacao) {
		this.observacao = observacao;
	}

}
