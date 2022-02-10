package br.com.controller;

import java.io.IOException;

import javax.servlet.http.HttpServletRequest;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RequestMethod;

import br.com.model.ItemModel;
import br.com.repository.ItemRepository;

@Controller
public class ItemController {

	@Autowired
	private ItemRepository itm;

	@RequestMapping(value = "/item.html", method = RequestMethod.GET)
	public String formItemGet() {
		return "/item.html";
	}

	@RequestMapping(value = "/item.html", method = RequestMethod.POST)
	public String formItemPost(HttpServletRequest request) throws IOException {
		
		ItemModel novoItem = new ItemModel();
		novoItem.setNome(request.getParameter("nome"));
		novoItem.setCusto(request.getParameter("custo"));
		novoItem.setPeso(request.getParameter("peso"));
		novoItem.setDescricao(request.getParameter("descricao"));
		itm.save(novoItem);
		
		return "redirect:/item.html";
	}
}