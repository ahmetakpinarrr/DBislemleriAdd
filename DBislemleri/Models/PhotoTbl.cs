using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class PhotoTbl
    {
        public int Id { get; set; }
        public string PhotoTitle { get; set; }
        public string PhotoPath { get; set; }
        public DateTime? PhotoCreateDate { get; set; }
    }
}
