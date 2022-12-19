using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class SliderBanner
    {
        public int Id { get; set; }
        public string ImgPath { get; set; }
        public string TopTitle { get; set; }
        public string MainTitle { get; set; }
        public string BottomTitle { get; set; }
        public int? Category { get; set; }
        public DateTime? CreateDate { get; set; }
    }
}
