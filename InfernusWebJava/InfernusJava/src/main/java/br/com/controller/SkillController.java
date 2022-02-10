package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.SkillModel;
import br.com.repository.SkillRepository;

@Controller
public class SkillController {

	@Autowired
	SkillRepository skl;
	
	@RequestMapping(value ="/skill.html", method = RequestMethod.GET)
	public String formSkillGet() {
		return "/skill.html";
	}
	
	@RequestMapping(value = "skill.html", method = RequestMethod.POST)
	public String formSkillPost(HttpServletRequest request, SkillModel novoSkl) throws IOException{
		
		novoSkl.setNome(request.getParameter("nome"));
		novoSkl.setTipo(request.getParameter("tipo"));
		novoSkl.setNivel(request.getParameter("nivel"));
		novoSkl.setDescricao(request.getParameter("descricao"));
		skl.save(novoSkl);
		
		return "redirect:/skill.html";
	}
}
