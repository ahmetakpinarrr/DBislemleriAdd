using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class MainMenu
    {
        public int MenuId { get; set; }
        public string MenuName { get; set; }
        public string MenuType { get; set; }
        public int? MenuOrder { get; set; }
        public DateTime? MenuCreatedAt { get; set; }
        public string MenuImage { get; set; }
    }
}
