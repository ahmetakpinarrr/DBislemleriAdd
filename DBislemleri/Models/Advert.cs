using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class Advert
    {
        public int Id { get; set; }
        public string AdvertPath { get; set; }
        public int? AdvertType { get; set; }
        public int? AdvertLocation { get; set; }
    }
}
