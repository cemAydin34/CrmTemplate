using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class LeadsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}