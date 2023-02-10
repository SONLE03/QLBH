using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
namespace Supermarket.Class
{
    public class md5
    {
        public md5()
        {

        }
        public string MD5Hash(string text)
        {
            MD5 MD5 = MD5.Create();
            byte[] hash = MD5.ComputeHash(Encoding.UTF8.GetBytes(text));
            StringBuilder hashSb = new StringBuilder();
            foreach (byte b in hash)
            {
                hashSb.Append(b.ToString("X2"));
            }
            return hashSb.ToString();
        }
    }
}
