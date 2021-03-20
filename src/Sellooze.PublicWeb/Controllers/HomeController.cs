using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Selloze.PublicWeb;
using Selloze.PublicWeb.Models;

namespace Sellooze.PublicWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ICoinCapService CoinCapService { get; set; }
        
        public HomeController(ILogger<HomeController> logger, ICoinCapService coinCapService)
        {
            _logger = logger;
            CoinCapService = coinCapService;
        }

        public async Task<IActionResult> Index()
        {
            var homeModel = new HomeViewModel();

            homeModel.CryptoList = await CoinCapService.RetrieveFrontValues();
            homeModel.GlobalData = await CoinCapService.RetrieveGlobalData();

            return View(homeModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }
    }
}