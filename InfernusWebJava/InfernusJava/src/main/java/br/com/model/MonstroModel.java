package br.com.model;

import java.io.Serializable;

import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import javax.validation.constraints.NotNull;

@Entity
public class MonstroModel implements Serializable {

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.AUTO)
	private Long id_monstro;

	@NotNull
	private String nome;

	@NotNull
	private String tipo;

	@NotNull
	private String tamanho;

	@NotNull
	private String tendencia;

	@NotNull
	private String hp;

	@NotNull
	private String ca;

	@NotNull
	private String desloc_t;
	
	private String desloc_e;
	private String desloc_n;
	private String desloc_v;
	private String desloc_s;

	@NotNull
	private String bp;
	@NotNull
	private String str;
	@NotNull
	private String dex;
	@NotNull
	private String con;
	@NotNull
	private String inte;
	@NotNull
	private String wis;
	@NotNull
	private String cha;
	@NotNull
	private String nd;

	@NotNull
	@Column(columnDefinition = "TEXT")
	private String tracos;
	@NotNull
	@Column(columnDefinition = "TEXT")
	private String caracteristicas;
	@NotNull
	@Column(columnDefinition = "TEXT")
	private String acoes;

	@Column(columnDefinition = "TEXT")
	private String acoeslendarias;

	public MonstroModel() {

	}

	public Long getId_Monstro() {
		return id_monstro;
	}

	public void setId_Monstro(Long id_monstro) {
		this.id_monstro = id_monstro;
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

	public String getTamanho() {
		return tamanho;
	}

	public void setTamanho(String tamanho) {
		this.tamanho = tamanho;
	}

	public String getTendencia() {
		return tendencia;
	}

	public void setTendencia(String tendencia) {
		this.tendencia = tendencia;
	}

	public String getHp() {
		return hp;
	}

	public void setHp(String hp) {
		this.hp = hp;
	}

	public String getCa() {
		return ca;
	}

	public void setCa(String ca) {
		this.ca = ca;
	}

	public String getStr() {
		return str;
	}

	public void setStr(String str) {
		this.str = str;
	}

	public String getDex() {
		return dex;
	}

	public void setDex(String dex) {
		this.dex = dex;
	}

	public String getCon() {
		return con;
	}

	public void setCon(String con) {
		this.con = con;
	}

	public String getInte() {
		return inte;
	}

	public void setInte(String inte) {
		this.inte = inte;
	}

	public String getWis() {
		return wis;
	}

	public void setWis(String wis) {
		this.wis = wis;
	}

	public String getCha() {
		return cha;
	}

	public void setCha(String cha) {
		this.cha = cha;
	}

	public String getTracos() {
		return tracos;
	}

	public void setTracos(String tracos) {
		this.tracos = tracos;
	}

	public String getCaracteristicas() {
		return caracteristicas;
	}

	public void setCaracteristicas(String caracteristicas) {
		this.caracteristicas = caracteristicas;
	}

	public String getAcoes() {
		return acoes;
	}

	public void setAcoes(String acoes) {
		this.acoes = acoes;
	}

	public String getAcoeslendarias() {
		return acoeslendarias;
	}

	public void setAcoeslendarias(String acoeslendarias) {
		this.acoeslendarias = acoeslendarias;
	}

	public String getDesloc_t() {
		return desloc_t;
	}

	public void setDesloc_t(String desloc_t) {
		this.desloc_t = desloc_t;
	}

	public String getDesloc_n() {
		return desloc_n;
	}

	public void setDesloc_n(String desloc_n) {
		this.desloc_n = desloc_n;
	}

	public String getDesloc_v() {
		return desloc_v;
	}

	public void setDesloc_v(String desloc_v) {
		this.desloc_v = desloc_v;
	}

	public String getDesloc_s() {
		return desloc_s;
	}

	public void setDesloc_s(String desloc_s) {
		this.desloc_s = desloc_s;
	}

	public String getNd() {
		return nd;
	}

	public void setNd(String nd) {
		this.nd = nd;
	}

	public String getBp() {
		return bp;
	}

	public void setBp(String bp) {
		this.bp = bp;
	}

	public String getDesloc_e() {
		return desloc_e;
	}

	public void setDesloc_e(String desloc_e) {
		this.desloc_e = desloc_e;
	}

}
