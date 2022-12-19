using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class ProdSubCategory
    {
        public int Id { get; set; }
        public string ProductSubCategoryName { get; set; }
        public int? ProductCategory { get; set; }
        public int? ProductSubCategoryMenu { get; set; }
        public string ProdCategoryImage { get; set; }
    }
}
