using Microsoft.AspNetCore.Mvc;

namespace FarmWMongoDb.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
