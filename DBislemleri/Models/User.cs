using System;
using System.Collections.Generic;

#nullable disable

namespace Dbislemleri.Models
{
    public partial class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string UserPhone { get; set; }
        public string UserMail { get; set; }
        public string UserPassword { get; set; }
        public bool? IsMailActive { get; set; }
        public bool? IsPhoneActive { get; set; }
        public int? CominicationPrefer { get; set; }
        public DateTime? SignUpDate { get; set; }
        public int? UserRole { get; set; }
        public string EmailValCode { get; set; }
    }
}
