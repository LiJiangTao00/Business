using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class Customer
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string UserPwd { get; set; }
        public string Usersex { get; set; }
        public string UserRealName { get; set; }
        public string Usertel { get; set; }
        public DateTime? Userbirthday { get; set; }
        public string Userlevel { get; set; }
        public string Useraddress { get; set; }
        public string Useremail { get; set; }
    }
}
