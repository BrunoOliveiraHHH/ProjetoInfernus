package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.ArmaduraModel;
import br.com.repository.ArmaduraRepository;

@Controller
public class ArmaduraController {
	
	@Autowired
	private ArmaduraRepository armd;
	
	@RequestMapping(value = "/armadura.html", method = RequestMethod.GET)
	public String formArmaduraGet() {
		return "/armadura.html";
	}
	
	@RequestMapping(value = "/armadura.html", method = RequestMethod.POST)
	public String formArmaduraPost(HttpServletRequest request) throws IOException {
		
		ArmaduraModel novaArmadura = new ArmaduraModel();
		novaArmadura.setNome(request.getParameter("nome"));
		novaArmadura.setTipo(request.getParameter("tipo"));
		novaArmadura.setCusto(request.getParameter("custo"));
		novaArmadura.setCa(request.getParameter("ca"));
		novaArmadura.setFurtv(request.getParameter("furtv"));
		novaArmadura.setForca(request.getParameter("forca"));
		novaArmadura.setPeso(request.getParameter("peso"));
		novaArmadura.setObservacao(request.getParameter("observacao"));
		armd.save(novaArmadura);
		
		return "redirect:/armadura.html";
	}

}
