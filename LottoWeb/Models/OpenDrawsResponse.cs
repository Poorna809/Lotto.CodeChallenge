using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LottoWeb.Models
{
    public class OpenDrawsResponse
    {
        public List<Draw> Draws { get; set; }

        public string ErrorInfo { get; set; }

        public bool Success { get; set; }

        
    }
}