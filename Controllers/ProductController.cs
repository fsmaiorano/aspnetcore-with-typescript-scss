using Microsoft.AspNetCore.Mvc;

namespace aspnetcore_with_typescript_scss.Controllers
{
    public class ProductController : Controller
    {
        public ProductController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
