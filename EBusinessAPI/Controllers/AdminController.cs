using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using Common;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using Model.ViewModel;

namespace EBusinessAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        private PracticalContext context;
        public AdminController(PracticalContext context)
        {
            this.context = context;
        }
        /// <summary>
        /// 用户等级显示积分显示
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public List<MemberGrade> ShowMemberGrade()
        {
            List<Customer> customers = context.Customer.ToList();
            List<OrderInfo> orders = context.OrderInfo.ToList();
            List<MemberGrade> members = (from c in customers
                                         join o in orders on c.UserId equals o.UserId
                                         select new MemberGrade
                                         {
                                             UserId = c.UserId,
                                             Id = c.UserId,
                                             UserName = c.UserName,
                                             Totalprice = o.Totalprice,
                                             Userlevel = c.Userlevel
                                         }).ToList();
            return members;
        }
        /// <summary>
        /// 修改等级
        /// </summary>
        /// <param name="intSize"></param>
        /// <returns></returns>
        [HttpPost]
        public int UptMemberGrade(string intSize)
        {
            int flag = 0;
            string[] vs = intSize.Split(',');
            foreach (var item in vs)
            {
                switch (Convert.ToInt32(item) / 1000)
                {
                    case 1:
                        ForMemberGrade(1);
                        break;
                    case 2:
                        ForMemberGrade(2);
                        break;
                    case 3:
                        ForMemberGrade(3);
                        break;
                    case 4:
                        ForMemberGrade(4);
                        break;
                    case 5:
                        ForMemberGrade(5);
                        break;
                    case 6:
                        ForMemberGrade(6);
                        break;
                    case 7:
                        ForMemberGrade(7);
                        break;
                    case 8:
                        ForMemberGrade(8);
                        break;
                    case 9:
                        ForMemberGrade(9);
                        break;
                    case 10:
                        ForMemberGrade(10);
                        break;
                    default:
                        ForMemberGrade(11);
                        break;
                }
                 flag=  context.SaveChanges();
            }
            return flag;
        }
        /// <summary>
        /// 修改等级调用方法
        /// </summary>
        /// <param name="i"></param>
        public void ForMemberGrade(int i)
        {
            MemberGrade member = ShowMemberGrade().Find(x => float.Parse(x.Totalprice.ToString()) / 1000 == i);
            Customer admin = context.Customer.ToList().Find(a => a.UserId == member.UserId);
            switch (i)
            {
                case 1:
                    admin.Userlevel = "一般挽留客户";
                    break;
                case 2:
                    admin.Userlevel = "一般保持客户";
                    break;
                case 3:
                    admin.Userlevel = "一般发展客户";
                    break;
                case 4:
                    admin.Userlevel = "一般价值客户";
                    break;
                case 5:
                    admin.Userlevel = "重要挽留客户";
                    break;
                case 6:
                    admin.Userlevel = "重要保持客户";
                    break;
                case 7:
                    admin.Userlevel = "重要保持客户";
                    break;
                case 8:
                    admin.Userlevel = "重要保持客户";
                    break;
                case 9:
                    admin.Userlevel = "重要发展客户";
                    break;
                case 10:
                    admin.Userlevel = "重要发展客户";
                    break;
                default:
                    admin.Userlevel = "重要价值客户";
                    break;
            }
            context.Entry(member).State = EntityState.Modified;
        }
        /// <summary>
        /// 注册用户
        /// </summary>
        /// <param name="customer"></param>
        /// <returns></returns>
        [HttpPost]
        public int RegistCustonmer(Customer customer)
        {
            customer.Userlevel = "一般挽留客户";
            customer.UserPwd = Md5Helper.ToMd5(customer.UserPwd);
            context.Customer.Add(customer);
            return context.SaveChanges();
        }
        /// <summary>
        /// 登录用户
        /// </summary>
        /// <param name="Cname">账号</param>
        /// <param name="Cpwd">密码</param>
        /// <returns></returns>
        [HttpGet]
        public int LoginCustonmer(string Cname,string Cpwd)
        {
            Cpwd = Md5Helper.ToMd5(Cpwd);
            Customer customer = context.Customer.ToList().Find(x => x.UserName.Equals(Cname) && x.UserPwd.Equals(Cpwd));
            if (customer!=null)
            {
                return 1;
            }
            return 0;
        }

    }
}
