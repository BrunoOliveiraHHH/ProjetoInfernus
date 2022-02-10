package br.com.model;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotNull;

@Entity
public class SkillModel implements Serializable{

	private static final long serialVersionUID = 6586468505375247756L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long id_skill;
	
	@NotNull
	private String nome;
	
	@NotNull
	private String tipo;
	
	@NotNull
	private String nivel;
	
	@NotNull
	@Column(columnDefinition = "TEXT")
	private String descricao;
	
	public SkillModel() {
		
	}

	public Long getId_skill() {
		return id_skill;
	}

	public void setId_skill(Long id_skill) {
		this.id_skill = id_skill;
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

	public String getNivel() {
		return nivel;
	}

	public void setNivel(String nivel) {
		this.nivel = nivel;
	}

	public String getDescricao() {
		return descricao;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}
	
	
	
}
