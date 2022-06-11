using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShopPet
{
    public class CProduct
    {
        public string id { get; set; }
        public string type { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public string price { get; set; }
        public string detail { get; set; }
        public CProduct(string id, string type, string image, string name, string price, string detail)
        {
            this.id = id;
            this.type = type;
            this.image = image;
            this.name = name;
            this.price = price;
            this.detail = detail;
        }

        public CProduct()
        {
        }
    }
}