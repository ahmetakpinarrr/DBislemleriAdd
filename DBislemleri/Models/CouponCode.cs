using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class CouponCode
    {
        public int Id { get; set; }
        public string CouponCode1 { get; set; }
        public bool? IsCouponUsed { get; set; }
        public DateTime? CouponCodeExpireDate { get; set; }
        public DateTime? CouponCreateDate { get; set; }
        public int? CouponDiscountRate { get; set; }
        public bool? IsUserHave { get; set; }
    }
}
