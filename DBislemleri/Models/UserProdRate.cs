using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class UserProdRate
    {
        public int Id { get; set; }
        public int? ProdId { get; set; }
        public int? UserId { get; set; }
        public double? UserProdRate1 { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
