using Dos.ORM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RCSApplication.Models
{
    public class DB
    {
        public static readonly DbSession Context = new DbSession("test_weixin");
    }
}