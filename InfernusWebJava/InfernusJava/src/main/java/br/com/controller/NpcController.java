package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.NpcModel;
import br.com.repository.NpcRepository;

@Controller
public class NpcController {

	@Autowired
	private NpcRepository npc;

	@RequestMapping(value = "/npc.html", method = RequestMethod.GET)
	public String formNpcGet() {

		return "/npc.html";
	}

	@RequestMapping(value = "/npc.html", method = RequestMethod.POST)
	public String formNpcPost(HttpServletRequest request) throws IOException {

		NpcModel novoNpc = new NpcModel();
		novoNpc.setClasse(request.getParameter("classe"));
		novoNpc.setNome(request.getParameter("nome"));
		novoNpc.setIdade(request.getParameter("idade"));
		novoNpc.setRaca(request.getParameter("raca"));
		npc.save(novoNpc);

		return "redirect:/npc.html";
	}
}
