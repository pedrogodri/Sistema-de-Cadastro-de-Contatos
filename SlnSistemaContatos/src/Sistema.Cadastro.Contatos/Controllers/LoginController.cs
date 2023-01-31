﻿using Microsoft.AspNetCore.Mvc;
using Sistema.Cadastro.Contatos.Models;
using Sistema.Cadastro.Contatos.Repository;
using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Sistema.Cadastro.Contatos.Controllers
{
    public class LoginController : Controller
    {
        private readonly IUsuarioRepositorio _usuarioRepositorio;
        public LoginController(IUsuarioRepositorio usuarioRepositorio)
        {
            _usuarioRepositorio = usuarioRepositorio;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Entrar(LoginModel loginModel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    UsuarioModel usuario = _usuarioRepositorio.BuscarLogin(loginModel.Login);

                    if(usuario != null)
                    {
                        if (usuario.SenhaValida(loginModel.Senha))
                        {
                            return RedirectToAction("Index", "Home");
                        }
                        TempData["MensagemErro"] = $"Senha do usuário é inválida. Por favor, tente novamente";
                    }
                    TempData["MensagemErro"] = $"Usuário e/ou senha inválido(s). Por favor, tente novamente";
                } 
                return View("Index");
            }
            catch (Exception erro)
            {
                TempData["MensagemErro"] = $"Não conseguimos realizar seu login, tente novamente, detalhe do erro: {erro.Message}";
                return RedirectToAction("Index");
            }
        }
    }

}
