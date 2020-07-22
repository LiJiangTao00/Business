using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Security.Cryptography;
using System.Text;

namespace Common
{
    public class Md5Helper
    {
        public  static string ToMd5(string TTT)
        {
            var MD5 = System.Security.Cryptography.MD5.Create();
            byte[] source = Encoding.UTF8.GetBytes(TTT);
            byte[] result = MD5.ComputeHash(source);
            string NTTT = "";
            foreach (byte b in result)
            {
                NTTT += b.ToString("X2");
            }
            return NTTT;
        }
    }
}