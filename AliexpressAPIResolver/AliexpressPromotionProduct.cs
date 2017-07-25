using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliexpressAPIResolver
{
    class AliexpressPromotionProduct
    {

        public class Rootobject
        {
            public Result result { get; set; }
            public int errorCode { get; set; }
        }

        public class Result
        {
            public int totalResults { get; set; }
            public Product[] products { get; set; }
        }

        public class Product
        {
            public int lotNum { get; set; }
            public string packageType { get; set; }
            public string imageUrl { get; set; }
            public string evaluationScore { get; set; }
            public string volume { get; set; }
            public int productId { get; set; }
            public string discount { get; set; }
            public string validTime { get; set; }
            public string commissionRate { get; set; }
            public string _30daysCommission { get; set; }
            public string originalPrice { get; set; }
            public string productTitle { get; set; }
            public string productUrl { get; set; }
            public string salePrice { get; set; }
            public string commission { get; set; }
        }

    }
}
