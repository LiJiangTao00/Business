using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class OrderInfo
    {
        public int Id { get; set; }
        public string OrderId { get; set; }
        public int UserId { get; set; }
        public DateTime Orderdate { get; set; }
        public int Orderamount { get; set; }
        public string Message { get; set; }
        public string Postmethod { get; set; }
        public string Paymethod { get; set; }
        public string Recevername { get; set; }
        public string Receveraddr { get; set; }
        public string Recevertel { get; set; }
        public string Memo { get; set; }
        public decimal Totalprice { get; set; }
    }
}
