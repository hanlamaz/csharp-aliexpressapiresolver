using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AliexpressAPIResolver
{
    class AliexpressProduct
    {


        public class Rootobject
        {
            public Result result { get; set; }
        }

        public class Result
        {
            public int totalResults { get; set; }
            public Product[] products { get; set; }
        }

        public class Product
        {
            public string localPrice { get; set; }
            public string imageUrl { get; set; }
            public string productUrl { get; set; }
            public string validTime { get; set; }
            public string productTitle { get; set; }
            public string volume { get; set; }
            public string salePrice { get; set; }
            public long productId { get; set; }
        }


    }
}
