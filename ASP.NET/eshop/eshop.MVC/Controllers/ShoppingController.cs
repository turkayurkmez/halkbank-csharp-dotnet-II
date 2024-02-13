using eshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.Controllers
{
    public class ShoppingController : Controller
    {
        private readonly IProductService productService;

        public ShoppingController(IProductService productService)
        {
            this.productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AddToCard(int id)
        {

            /*
             * 1. seçilen ürünü getir.
             * 2. Eğer ilk kez sepete ürün ekleniyorsa, session içinde bir koleksiyon oluştur.
             *    Eğer daha önce eklenmiş ise session içindeki koleksiyonu döndür!
             * 3. Koleksiyona ürünü ekle.
             * 4. Durumu İstemciye bildir
             */


            //    * 1. seçilen ürünü getir.
            var product = productService.GetProductAsync(id);


            return Json(new { message = $"{product.Result.Name} isimli ürün sepete eklendi" });
        }
    }
}
