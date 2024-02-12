using eshop.Entities;
using eshop.MVC.Models;
using eshop.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace eshop.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService productService;

        public HomeController(ILogger<HomeController> logger, IProductService productService)
        {
            _logger = logger;
            this.productService = productService;
        }

        public IActionResult Index(int page = 1, int categoryId = 0)
        {

            var products = productService.GetProducts(categoryId);




            /*
         * 103 ürününüz var.
         * Her sayfada 10 ürün göstereceksem
         * Kaç sayfam olmalı?
         * 
         * 103/10 = 10.3 -> 11
         * 
         */
            var productsCount = products.Count();
            var productPerPage = 4;



            var totalPages = (int)Math.Ceiling((decimal)productsCount / productPerPage);
            ViewBag.TotalPages = totalPages;
            ViewBag.CurrentPage = page;
            ViewBag.CurrentCategory = categoryId;

            var paginated = products.OrderBy(p => p.Id)
                                    .Skip((page - 1) * productPerPage)
                                    .Take(productPerPage);


            return View(paginated);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
