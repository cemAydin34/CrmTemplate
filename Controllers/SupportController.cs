using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class SupportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}