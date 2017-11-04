using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;

namespace RCSApplication.Models
{
    public class Base64
    {
        public string Encode(string EncodeStr)
        {
            byte[] bytes = Encoding.Default.GetBytes(EncodeStr);
            return Convert.ToBase64String(bytes);
        }
        public string Decode(string DecodeStr)
        {
            byte[] outputb = Convert.FromBase64String(DecodeStr);
            return Encoding.Default.GetString(outputb);
        }
    }
}