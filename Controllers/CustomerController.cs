using Microsoft.AspNetCore.Mvc;

namespace CrmTemplate.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Müşteri Detay Sayfası
        public IActionResult Detay()
        {
            return View();
        }

        public IActionResult Import()
        {
            return View();
        }

        // Partial Views

        public IActionResult _Profile()
        {
            return View();
        }

        public IActionResult _Contacts()
        {
            return View();
        }

        public IActionResult _Notes()
        {
            return View();
        }

        public IActionResult _Invoices()
        {
            return View();
        }

        public IActionResult _Payments()
        {
            return View();
        }
        public IActionResult _Proposals()
        {
            return View();
        }

        public IActionResult _CreditNotes()
        {
            return View();
        }

        public IActionResult _Estimates()
        {
            return View();
        }

        public IActionResult _Subscriptions()
        {
            return View();
        }

        public IActionResult _Expenses()
        {
            return View();
        }
        public IActionResult _Projects()
        {
            return View();
        }

        public IActionResult _Contracts()
        {
            return View();
        }

        public IActionResult _Tasks()
        {
            return View();
        }

        public IActionResult _Tickets()
        {
            return View();
        }

        public IActionResult _Files()
        {
            return View();
        }

        public IActionResult _Reminders()
        {
            return View();
        }

        public IActionResult _Statement()
        {
            return View();
        }


    }
}
