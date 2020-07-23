using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ViewModel
{
    public class MemberGrade
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
        public int Id { get; set; }
        public string OrderId { get; set; }
        public DateTime Orderdate { get; set; }
        public int Orderamount { get; set; }
        public string Message { get; set; }
        public string Postmethod { get; set; }
        public string Paymethod { get; set; }
        public string Recevername { get; set; }
        public string Receveraddr { get; set; }
        public string Recevertel { get; set; }
        public string Memo { get; set; }
        public decimal Totalprice { get; set; }
    }
}
