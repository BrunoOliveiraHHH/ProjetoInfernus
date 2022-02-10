package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.VeiculoModel;
import br.com.repository.VeiculoRepository;

@Controller
public class VeiculoController {

	@Autowired
	private VeiculoRepository veic;

	@RequestMapping(value = "/veiculo.html", method = RequestMethod.GET)
	public String formVeiculoGet() {
		return "/veiculo.html";
	}

	@RequestMapping(value = "/veiculo.html", method = RequestMethod.POST)
	public String formVeiculoPost(HttpServletRequest request) throws IOException {

		VeiculoModel novoVeiculo = new VeiculoModel();
		novoVeiculo.setNome(request.getParameter("nome"));
		novoVeiculo.setCusto(request.getParameter("custo"));
		novoVeiculo.setVelocidade(request.getParameter("velocidade"));
		novoVeiculo.setTipo(request.getParameter("tipo"));
		veic.save(novoVeiculo);

		return "redirect:/veiculo.html";
	}

}
