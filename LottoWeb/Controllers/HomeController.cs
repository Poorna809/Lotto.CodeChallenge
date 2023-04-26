using LottoWeb.Models;
using LottoWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LottoWeb.Controllers
{
    public class HomeController : Controller
    {

        private IOpenDrawsService _openDrawsService;
        

        public HomeController(IOpenDrawsService openDrawsService)
        {
            _openDrawsService = openDrawsService;
        }



        public ActionResult Index()
        {
            var openDrawsRequest = new OpenDrawsRequest()
            {
                CompanyId = "GoldenCasket",//can be configured in web config
                MaxDrawCount = 10,
                OptionalProductFilter = new[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
            };

            var viewModel = new HomeViewModel()
            {
                OpenDraws = _openDrawsService.GetOpenDraws(openDrawsRequest).Result?.Draws.ToList()
            };

            return View(viewModel);
        }

      
    }
}