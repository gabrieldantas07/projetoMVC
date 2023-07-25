using Microsoft.AspNetCore.Mvc;

namespace cadastroclientes.Controllers
{
    public class clientecontroler : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
