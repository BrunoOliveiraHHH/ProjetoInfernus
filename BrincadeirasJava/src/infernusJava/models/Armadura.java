package infernusJava.models;

public class Armadura {

	private int id;
	private String nome;
	private String tipo;
	private String custo;
	private String ca;
	private String forca;
	private String furtv;
	private String peso;
	private String observacao;

	public Armadura() {

	}

	public int getId() {
		return id;
	}

	public void setId(int id) {
		this.id = id;
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

	public String getForca() {
		return forca;
	}

	public void setForca(String forca) {
		this.forca = forca;
	}

	public String getFurtv() {
		return furtv;
	}

	public void setFurtv(String furtv) {
		this.furtv = furtv;
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

	@Override
	public String toString() {
		return "Armadura [id=" + id + ", nome=" + nome + ", tipo=" + tipo + ", custo=" + custo + ", ca=" + ca
				+ ", forca=" + forca + ", furtv=" + furtv + ", peso=" + peso + ", observacao=" + observacao + "]";
	}

	public Armadura(int id, String nome, String tipo, String custo, String ca, String forca, String furtv, String peso,
			String observacao) {
		super();
		this.id = id;
		this.nome = nome;
		this.tipo = tipo;
		this.custo = custo;
		this.ca = ca;
		this.forca = forca;
		this.furtv = furtv;
		this.peso = peso;
		this.observacao = observacao;
	}

}
