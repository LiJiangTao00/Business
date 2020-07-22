using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Model.Models;

namespace EBusinessAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private PracticalContext context;
        public ValuesController(PracticalContext _context)
        {
            context = _context;
        }
        public List<AdminInfo> ShowAdmin()
        {
            return context.AdminInfo.ToList();
        }
        public int AddAdmin()
        {
            AdminInfo admin = new AdminInfo
            {
                AdminFlag = 1,
                AdminName = "11",
                AdminPwd = "11"
            };
            context.AdminInfo.Add(admin);
            return context.SaveChanges();
        }
        public int DelAdmin(int id)
        {
            AdminInfo admin = context.AdminInfo.ToList().Where(x => x.AdminId == 8).FirstOrDefault();
            context.AdminInfo.Remove(admin);
            return context.SaveChanges();
        }
        public int UptAdmin()
        {
            AdminInfo admin = new AdminInfo
            {
                AdminId=7,
                AdminFlag = 1,
                AdminName = "11",
                AdminPwd = "11"
            };
            context.Entry(admin).State = EntityState.Modified;
            return context.SaveChanges();
        }
    }
}
