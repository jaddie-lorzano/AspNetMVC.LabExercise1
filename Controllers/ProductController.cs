using AspNetMVC.LabExercise1.Configuration;
using AspNetMVC.LabExercise1.Services;
using Microsoft.AspNetCore.Mvc;

namespace AspNetMVC.LabExercise1.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult List()
        {
            ViewData["EmailSettings"] = _emailSettings;
            ViewData["ProductGrandTotal"] = _productService.GetGrandTotal().ToString("C2");
            ViewData["ProductList"] = _productService.GetCatalog();
            return View();
        }

        private readonly ProductService _productService;
        private readonly EmailSettings _emailSettings;
        public ProductController(EmailSettings emailSettings, ProductService productService)
        {
            _emailSettings = emailSettings;
            _productService = productService;
        }
    }
}
