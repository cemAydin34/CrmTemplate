using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class InvoicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
