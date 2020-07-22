using System;
using System.Collections.Generic;

namespace Model.Models
{
    public partial class AdminInfo
    {
        public int AdminId { get; set; }
        public string AdminName { get; set; }
        public string AdminPwd { get; set; }
        public int AdminFlag { get; set; }
    }
}
