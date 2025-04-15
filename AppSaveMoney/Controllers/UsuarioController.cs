using Microsoft.AspNetCore.Mvc;

namespace AppSaveMoney.Controllers {
    public class UsuarioController : Controller {
        public IActionResult Index() {
            return View();
        }
    }
}
