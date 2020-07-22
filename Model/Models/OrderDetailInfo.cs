using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class OrderDetailInfo
    {
        public int Id { get; set; }
        public int OrderDetailId { get; set; }
        public string OrderId { get; set; }
        public int ProductId { get; set; }
        public int Orderamount { get; set; }
        public string Poststatus { get; set; }
        public string Recevstatus { get; set; }
        public decimal Saletotalprice { get; set; }
    }
}
