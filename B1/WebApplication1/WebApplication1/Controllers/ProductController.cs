using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    //[Route("product2")]
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //[HttpGet("detail")]
        public IActionResult Detail()
        {
            return View();
        }

    }
}
