using Microsoft.AspNetCore.Mvc;

namespace Take.EcoRodovias.API.Controllers
{
    public class BasesOperacionaisController : MainController
    {
        [HttpGet("ecorodovias/api/bases")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
