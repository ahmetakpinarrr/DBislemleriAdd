using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class ProdCategory
    {
        public int ProductCategoryId { get; set; }
        public int ProductMenuId { get; set; }
        public string ProductCategoryName { get; set; }
        public int? ProductCategoryTypeId { get; set; }
        public string ProductCategoryDesc { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public string ProdCategoryImage { get; set; }
    }
}
