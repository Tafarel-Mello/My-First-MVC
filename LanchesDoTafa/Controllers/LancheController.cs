using Microsoft.AspNetCore.Mvc;

namespace LanchesDoTafa.Controllers
{
    public class LancheController : Controller
    {

        public IActionResult List()
        {
            return View();
        }
    }
}
