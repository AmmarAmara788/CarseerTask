using Microsoft.AspNetCore.Mvc;

namespace CarseerTask.Controllers
{
    public class MethodsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
