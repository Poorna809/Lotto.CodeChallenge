using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LottoWeb.Models
{
    public class OpenDrawsRequest
    {
        public string CompanyId { get; set; }

        public int MaxDrawCount { get; set; }

        public string[] OptionalProductFilter { get; set; }
    }
}