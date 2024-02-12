using IntroDotNetCore.Models;
using IntroDotNetCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace IntroDotNetCore.Controllers
{
    public class AnaSayfaController : Controller
    {
        public IActionResult Giris()
        {
            ViewBag.Name = "Türkay";
            ViewBag.Date = DateTime.Now.Date;

            var hotels = new List<Hotel>()
            {
                new() { Name="Kardeşler pansiyon", Location="Kartepe", Features="Karlı", Id=1},
                new() { Name="Ibis Otel", Location="Uluddağ", Features="Karlı ve Yüzme havuzlu", Id=2},

            };



            return View(hotels);
        }

        public IActionResult DaveteYanit()
        {
            return View();
        }
        [HttpPost]
        public IActionResult DaveteYanit(UserResponse userResponse)
        {
            if (ModelState.IsValid)
            {
                if (userResponse.IsParticipate)
                {
                    UserService.AddUserResponse(userResponse);
                }

                var viewModel = new UserResponseViewModel
                {
                    UserResponse = userResponse,
                    Participants = UserService.GetUserResponses()
                };


                return View("Durum", viewModel);
            }

            return View();
        }
    }
}
