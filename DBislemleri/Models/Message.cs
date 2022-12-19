using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class Message
    {
        public int Id { get; set; }
        public string Isim { get; set; }
        public string Iletisim { get; set; }
        public string Konu { get; set; }
    }
}
