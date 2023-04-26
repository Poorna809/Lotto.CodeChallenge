using LottoWeb.Models;
using LottoWeb.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LottoWeb.Services
{
    public class OpenDrawsService : BaseService, IOpenDrawsService
    {
        private string Baseurl = "https://data.api.thelott.com"; // this can be configured in web config in case the URL is different for other environments
        public OpenDrawsService (HttpClient httpClient) : base(httpClient) 
        {
        }

        public async Task<OpenDrawsResponse> GetOpenDraws(OpenDrawsRequest request)
        {
            return await PostAsync<OpenDrawsResponse>(Baseurl + "/sales/vmax/web/data/lotto/opendraws", request).ConfigureAwait(false);
        }
    }
}