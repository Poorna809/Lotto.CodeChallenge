using LottoWeb.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace LottoWeb.Services
{
    public abstract class BaseService
    {
        private readonly HttpClient _httpClient;

        public BaseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<T> PostAsync<T>(string apiEndpoint, OpenDrawsRequest request)
        {
            try
            {
                var content = JsonConvert.SerializeObject(request);

                //var buffer = System.Text.Encoding.UTF8.GetBytes(data);
                //var byteContent = new ByteArrayContent(buffer);

                var httpContent = new StringContent(content);


                var response = await _httpClient.PostAsync(apiEndpoint, httpContent).ConfigureAwait(false);

                if (response.IsSuccessStatusCode == true)
                {
                    var json = await response.Content.ReadAsStringAsync();

                    return JsonConvert.DeserializeObject<T>(json);
                }
                else
                {
                    return default;
                }

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}