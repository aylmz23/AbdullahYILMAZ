using Microsoft.AspNetCore.Mvc;

namespace AbdullahYILMAZ.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
