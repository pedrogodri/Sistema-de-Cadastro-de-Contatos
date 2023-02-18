using Microsoft.AspNetCore.Mvc;
using Sistema.Cadastro.Contatos.Filters;
using Sistema.Cadastro.Contatos.Models;
using System.Diagnostics;

namespace Sistema.Cadastro.Contatos.Controllers
{
    [PaginaUsuarioLogado]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}