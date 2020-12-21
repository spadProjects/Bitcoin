using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;

namespace Bitcoin.Web.Classes
{
    public static class Payeer
    {
        public static string Pay()
        {
            var m_shop = "1246264013";
            var m_orderid = "1";
            var m_amount = "1.00";
            var m_curr = "USD";
            var m_desc = Base64Encode("Test");
            var m_key = "123";
            var arr = new string[] { m_shop, m_orderid, m_amount, m_curr, m_desc, m_key };
            var m_sign = sign_hash(String.Join(":", arr));
            String url = "https://payeer.com/merchant/?m_shop=" + m_shop + "&m_orderid=" +
                         m_orderid + "&m_amount=" + m_amount + "&m_curr=" + m_curr + "&m_desc=" +
                         m_desc + "&m_sign=" + m_sign;
            return url;
        }
        public static string sign_hash(string text)
        {
            byte[] data = Encoding.Default.GetBytes(text);
            var result = new SHA256Managed().ComputeHash(data);
            return BitConverter.ToString(result).Replace("-", "").ToUpper();
        }
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }
    }
}
