using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class ShowcaseProduct
    {
        public int Id { get; set; }
        public int? ShowcaseId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
