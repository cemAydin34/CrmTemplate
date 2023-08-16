using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class ExpensesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}

