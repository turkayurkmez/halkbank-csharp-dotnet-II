using eshop.Services;
using eshop.Services.DataTransferObjects.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace eshop.MVC.Controllers
{
    [Authorize(Roles = "admin,editor")]
    public class ProductsController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService categoryService;

        public ProductsController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            this.categoryService = categoryService;
        }
        //[AllowAnonymous]: Bu action'a insanların girebilmesini isterseniz, anonim kullanıcılara izin vermelisiniz!
        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductsAsync();
            return View(products);
        }


        public IActionResult Create()
        {
            ViewBag.Categories = getCategories();
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(CreateProductRequest request)
        {
            if (ModelState.IsValid)
            {
                await _productService.CreateAsync(request);
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Categories = getCategories();
            return View();
        }

        public async Task<IActionResult> Edit(int id)
        {
            var product = await _productService.GetProductForUpdateAsync(id);

            ViewBag.Categories = getCategories();
            return View(product);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(UpdateProductRequest request)
        {
            if (ModelState.IsValid)
            {
                await _productService.UpdateAsync(request);
                return RedirectToAction(nameof(Index));

            }
            ViewBag.Categories = getCategories();
            return View();
        }

        private IEnumerable<SelectListItem> getCategories()
        {
            var categories = categoryService.GetCategories();
            return categories.Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });


        }


    }
}
