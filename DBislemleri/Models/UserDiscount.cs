using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class UserDiscount
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public int? CouponCodeId { get; set; }
        public int? UserDiscountRate { get; set; }
    }
}
