using LottoWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace LottoWeb.Services.Interfaces
{
    public interface IOpenDrawsService
    {
        Task<OpenDrawsResponse> GetOpenDraws(OpenDrawsRequest request);
    }
}