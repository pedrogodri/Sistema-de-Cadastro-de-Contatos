using Microsoft.AspNetCore.Mvc;

namespace Sistema.Cadastro.Contatos.Controllers
{
    public class UsuarioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
