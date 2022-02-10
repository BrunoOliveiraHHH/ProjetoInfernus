package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.MunicaoModel;
import br.com.repository.MunicaoRepository;

@Controller
public class MunicaoController {

	@Autowired
	MunicaoRepository muni;

	@RequestMapping(value = "/municaoarmas.html", method = RequestMethod.GET)
	public String formMunicaoGet() {
		return "/municaoarmas.html";
	}
	
	@RequestMapping(value = "/municaoarmas.html", method = RequestMethod.POST)
	public String formMunicaoPost(HttpServletRequest request) throws IOException {
		
		MunicaoModel novaMunicao = new MunicaoModel();
		novaMunicao.setArmas(request.getParameter("armas"));
		novaMunicao.setCalibre(request.getParameter("calibre"));
		novaMunicao.setCusto(request.getParameter("custo"));
		novaMunicao.setNome(request.getParameter("nome"));
		novaMunicao.setObservacao(request.getParameter("observacao"));
		novaMunicao.setPeso(request.getParameter("peso"));
		novaMunicao.setQuantidade(request.getParameter("quantidade"));
		muni.save(novaMunicao);
		
		return "redirect:/municaoarmas.html";
	}

}
