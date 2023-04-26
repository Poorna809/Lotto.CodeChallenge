using LottoWeb.Models;
using LottoWeb.Services;
using LottoWeb.Services.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net.Http;

namespace LottoWeb.Tests
{
    [TestClass]
    public class OpenDrawsServiceTest
    {
        private IOpenDrawsService _openDrawsService;

        [TestInitialize]
        public void InitialSetup()
        {
            var httpClient = new HttpClient()
            {
                BaseAddress = new Uri("https://data.api.thelott.com")
            };

            _openDrawsService = new OpenDrawsService(httpClient);
        }

        [TestMethod]
        public void ReturnData()
        {
            var drawRequest = new OpenDrawsRequest()
            {
                CompanyId = "GoldenCasket",
                MaxDrawCount = 20,
                OptionalProductFilter = new[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
            };

            var results = _openDrawsService.GetOpenDraws(drawRequest).Result;

            // Assert
            Assert.IsTrue(results.Success);
        }

        [TestMethod]
        public void ReturnNull()
        {
            var drawRequest = new OpenDrawsRequest()
            {
                CompanyId = "GoldenCasket",
                MaxDrawCount = 20,
                OptionalProductFilter = new[] { "TattsLotto", "MonWedLotto", "OzLotto", "MonWedLotto", "Powerball", "Super66" }
            };

            var results = _openDrawsService.GetOpenDraws(drawRequest).Result;

            // Assert
            Assert.IsNull(results.ErrorInfo);
        }
    }

    

}
