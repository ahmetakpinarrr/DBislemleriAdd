using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class ProductCategoryRelation
    {
        public int RelationId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductCategoryId { get; set; }
    }
}
