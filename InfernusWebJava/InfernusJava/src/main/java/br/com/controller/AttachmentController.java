package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.AttachmentModel;
import br.com.repository.AttachmentRepository;

@Controller
public class AttachmentController {

	@Autowired
	AttachmentRepository att;
	
	@RequestMapping(value = "/attachment.html", method = RequestMethod.GET)
	public String formAttachmentGet() {
		return "/attachment.html";
	}
	
	@RequestMapping(value = "/attachment.html", method = RequestMethod.POST)
	public String formAttachmentPost(HttpServletRequest request) throws IOException{
		
		AttachmentModel novoAtt = new AttachmentModel();
		novoAtt.setNome(request.getParameter("nome"));
		novoAtt.setCusto(request.getParameter("custo"));
		novoAtt.setPeso(request.getParameter("peso"));
		novoAtt.setTipo(request.getParameter("tipo"));
		novoAtt.setEfeito(request.getParameter("efeito"));
		novoAtt.setObservacao(request.getParameter("observacao"));
		att.save(novoAtt);
		
		return "redirect:/attachment.html";
	}
	
}
