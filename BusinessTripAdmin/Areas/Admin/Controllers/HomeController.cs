using Microsoft.AspNetCore.Mvc;

namespace BusinessTripAdmin.Areas.Admin.Controllers
{
    public class HomeController : BaseAreaController
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
