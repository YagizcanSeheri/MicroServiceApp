using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BasketAPI.EntityLayer.Entities
{
    public class BasketCartItem
    {
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string ProductId { get; set; }
        public string ProductName { get; set; }
    }
}
