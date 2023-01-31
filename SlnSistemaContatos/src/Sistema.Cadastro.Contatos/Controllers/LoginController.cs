using Microsoft.AspNetCore.Mvc;

namespace Sistema.Cadastro.Contatos.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
