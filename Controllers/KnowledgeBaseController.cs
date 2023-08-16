using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class KnowledgeBaseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
