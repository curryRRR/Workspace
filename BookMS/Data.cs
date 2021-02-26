using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMS
{
    class Data
    {
        public static Dao dao = new Dao(); 
        //存储当前登录的用户的ID
        public static string UID { get; set; }
        //存储当前登录用户的姓名
        public static string UName { get; set; }
    }
}
