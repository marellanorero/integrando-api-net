using Microsoft.AspNetCore.Mvc;

namespace SistemaGestion.Controllers
{
    public class VentaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
