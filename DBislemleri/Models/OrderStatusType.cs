using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class OrderStatusType
    {
        public int Id { get; set; }
        public int? StatusTypeId { get; set; }
        public string StatusName { get; set; }
    }
}
