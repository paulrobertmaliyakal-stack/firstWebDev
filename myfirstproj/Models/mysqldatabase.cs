using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myfirstproj.Models
{
    public class mysqldatabase
    {
        public static int index { get; set; } = 0;
       public static List<logindata> table = new List<logindata>();
    }
}