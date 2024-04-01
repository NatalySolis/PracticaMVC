using Microsoft.AspNetCore.Mvc;

namespace Ejemplo_de_MVC2.Controllers
{
    public class vistasRazorController : Controller
    {

        // GET: vistasRazor
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult bloqueMultiple()
        {
            return View();
        }
    }
}
