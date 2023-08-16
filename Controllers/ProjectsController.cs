using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class ProjectsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
