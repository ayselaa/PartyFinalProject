using Business.Services;
using Business.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace MyFinallyProje.Controllers
{
    public class BasketController : Controller
    {
        private readonly LayoutService _layoutService;

        public BasketController(LayoutService layoutService)
        {
            _layoutService = layoutService;
        }

        public IActionResult Index()
        {

            return View();
        }

        public List<BasketVM> GetBaskets()
        {
            var datas = _layoutService.GetBasket();
            return datas;
        }

    }
}
