using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class ItemsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
