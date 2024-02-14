using eshop.MVC.Extensions;
using eshop.MVC.Models;
using eshop.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

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
            var collection = getCollectionFromSession();
            return View(collection);
        }

        public IActionResult AddToCard(int id)
        {

            //    * 1. seçilen ürünü getir.
            var product = productService.GetProductAsync(id).Result;

            // Eğer ilk kez sepete ürün ekleniyorsa, session içinde bir koleksiyon oluştur.
            // Eğer daha önce eklenmiş ise session içindeki koleksiyonu döndür!
            var collection = getCollectionFromSession();
            //  * 3. Koleksiyona ürünü ekle.
            collection.Add(new CardItem { Product = product, Quantity = 1 });
            //  4. Koleksiyonu sessiona ekle
            saveCollectionToSession(collection);

            //  * 5. Durumu İstemciye bildir
            return Json(new { message = $"{product.Name} isimli ürün sepete eklendi" });
        }

        private void saveCollectionToSession(ShoppingCardCollection collection)
        {
            var jsonString = JsonConvert.SerializeObject(collection);
            HttpContext.Session.SetString("shop", jsonString);
        }

        private ShoppingCardCollection getCollectionFromSession()
        {

            //if (HttpContext.Session.GetString("shop") == null)
            //{
            //    ShoppingCardCollection shoppingCardCollection = new ShoppingCardCollection();
            //    var jsonString = JsonConvert.SerializeObject(shoppingCardCollection);
            //    HttpContext.Session.SetString("shop", jsonString);
            //}


            //return JsonConvert.DeserializeObject<ShoppingCardCollection>(HttpContext.Session.GetString("shop"));

            return HttpContext.Session.GetJson<ShoppingCardCollection>("shop");


        }
    }
}
