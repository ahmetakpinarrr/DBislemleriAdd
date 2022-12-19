using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class AdminUser
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }
        public string UserPassword { get; set; }
        public int? UserRole { get; set; }
        public DateTime? UserCreatedDate { get; set; }
    }
}
