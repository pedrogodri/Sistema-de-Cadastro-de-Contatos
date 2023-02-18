using Microsoft.AspNetCore.Mvc;
using Sistema.Cadastro.Contatos.Filters;

namespace Sistema.Cadastro.Contatos.Controllers
{
    [PaginaUsuarioLogado]
    public class RestritoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
