using Microsoft.AspNetCore.Mvc;

namespace ajax_demo1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("Customer");
        }
    }
}
