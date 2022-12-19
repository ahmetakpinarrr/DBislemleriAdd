using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class Town
    {
        public int Id { get; set; }
        public string TownName { get; set; }
        public int CityId { get; set; }
    }
}
