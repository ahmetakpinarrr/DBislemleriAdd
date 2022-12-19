using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int? OrderHeaderId { get; set; }
        public int? ProductId { get; set; }
        public string ProductFullName { get; set; }
        public string ProductCode { get; set; }
        public string ProductStockCode { get; set; }
        public int? OrderQuantity { get; set; }
        public decimal? OrderTotalAmount { get; set; }
        public DateTime? OrderCreateDate { get; set; }
    }
}
