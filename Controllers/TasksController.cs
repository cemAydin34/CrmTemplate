using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class TasksController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
