using Microsoft.AspNetCore.Mvc;

namespace Sistema.Cadastro.Contatos.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
