using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class PaymentsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
