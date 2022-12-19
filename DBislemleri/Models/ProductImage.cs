using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public string ProductImagePath { get; set; }
        public DateTime? CreatedAt { get; set; }
    }
}
