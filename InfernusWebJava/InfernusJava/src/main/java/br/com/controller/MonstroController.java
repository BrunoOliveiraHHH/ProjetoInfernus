package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.MonstroModel;
import br.com.repository.MonstroRepository;

@Controller
public class MonstroController {
	
	@Autowired
	private MonstroRepository mon;
	
	@RequestMapping(value = "/monstro.html", method = RequestMethod.GET)
	public String formMonstroGet() {
		return "/monstro.html";
	}
	
	@RequestMapping(value = "/monstro.html", method = RequestMethod.POST)
	public String formMonstroPost(HttpServletRequest request) throws IOException {
		
		MonstroModel novoMonstro = new MonstroModel();
		novoMonstro.setNome(request.getParameter("nome"));
		novoMonstro.setTipo(request.getParameter("tipo"));
		novoMonstro.setTamanho(request.getParameter("tamanho"));
		novoMonstro.setTendencia(request.getParameter("tendencia"));
		novoMonstro.setHp(request.getParameter("hp"));
		novoMonstro.setCa(request.getParameter("ca"));
		novoMonstro.setDesloc_n(request.getParameter("desloc_n"));
		novoMonstro.setDesloc_s(request.getParameter("desloc_s"));
		novoMonstro.setDesloc_t(request.getParameter("desloc_t"));
		novoMonstro.setDesloc_v(request.getParameter("desloc_v"));
		novoMonstro.setDesloc_e(request.getParameter("desloc_e"));
		novoMonstro.setBp(request.getParameter("bp"));
		novoMonstro.setStr(request.getParameter("str"));
		novoMonstro.setDex(request.getParameter("dex"));
		novoMonstro.setCon(request.getParameter("con"));
		novoMonstro.setInte(request.getParameter("inte"));
		novoMonstro.setWis(request.getParameter("wis"));
		novoMonstro.setCha(request.getParameter("cha"));
		novoMonstro.setTracos(request.getParameter("tracos"));
		novoMonstro.setNd(request.getParameter("nd"));
		novoMonstro.setCaracteristicas(request.getParameter("caracteristicas"));
		novoMonstro.setAcoes(request.getParameter("acoes"));
		novoMonstro.setAcoeslendarias(request.getParameter("acoeslendarias"));
		mon.save(novoMonstro);
		
		return "redirect:/monstro.html";	
	}

}
