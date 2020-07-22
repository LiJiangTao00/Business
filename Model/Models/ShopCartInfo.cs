using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class ShopCartInfo
    {
        public int UserId { get; set; }
        public int? ProductId { get; set; }
        public int Orderamount { get; set; }
        public decimal Price { get; set; }
        public string Ispay { get; set; }
    }
}
