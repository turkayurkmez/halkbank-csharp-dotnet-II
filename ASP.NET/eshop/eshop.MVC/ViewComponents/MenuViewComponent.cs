using eshop.DataAccess.Repositories;
using eshop.Services;
using Microsoft.AspNetCore.Mvc;

namespace eshop.MVC.ViewComponents
{
    public class MenuViewComponent : ViewComponent
    {

        private readonly ICategoryService service;

        public MenuViewComponent(ICategoryService service)
        {
            this.service = service;
        }

        public IViewComponentResult Invoke()
        {
            var categories = service.GetCategories();
            return View(categories);
        }
    }
}
