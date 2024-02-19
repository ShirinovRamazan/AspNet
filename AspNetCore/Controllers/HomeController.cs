using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Controllers
{
    public  class HomeController : Controller
    {
        public async  Task<IActionResult> Index()
        {
            return View();
        }
    }
}
