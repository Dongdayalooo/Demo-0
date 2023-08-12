using Microsoft.AspNetCore.Mvc;

namespace ClothingShop.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
