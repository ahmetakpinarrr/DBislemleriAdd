using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class Showcase
    {
        public int Id { get; set; }
        public string ShowcaseName { get; set; }
        public int? ShowcaseLocation { get; set; }
        public bool? ShowcaseIsActive { get; set; }
        public DateTime? ShowcaseCreateDate { get; set; }
        public DateTime? ShowcaseUpdateDate { get; set; }
    }
}
