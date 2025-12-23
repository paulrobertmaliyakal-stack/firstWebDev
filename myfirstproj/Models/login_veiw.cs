using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace myfirstproj.Models
{
    public class login_veiw
    {
        public logindata userdata { get; set; }
        public bool incorrectpass { get; set; }
        public bool incorrectcred { get; set; }
        public string newuser { get; set; }
        public string changepass { get; set; }

    }
}