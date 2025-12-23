using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using myfirstproj.Models;

namespace myfirstproj.Controllers
{

    public class ProgramController : Controller
    {
        // GET: Program

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(login_veiw model)
        {
            if (mysqldatabase.index == 0 && !(string.IsNullOrWhiteSpace(model.newuser)))
            {
                mysqldatabase.index++;
                mysqldatabase.table.Add(model.userdata);
                return View();
            }
            else
            {
                for (int i = 0; i < mysqldatabase.index; i++)
                {
                    if (mysqldatabase.table[i].username == model.userdata.username)
                    {
                        if (!(string.IsNullOrWhiteSpace(model.changepass)))
                        {
                            mysqldatabase.table[i].pass = model.userdata.pass;
                            return Content(string.Format("the password of {0} has been changed", model.userdata.username));
                        }
                        else if (mysqldatabase.table[i].pass == model.userdata.pass)
                        {
                            return Content("Authentication success");
                        }
                        else
                        {
                            return Content("incorrect password");
                        }
                    }

                    else if(i == mysqldatabase.index - 1)
                    {
                            if (!(string.IsNullOrWhiteSpace(model.newuser)))
                            {
                                mysqldatabase.table.Add(new logindata { username = model.userdata.username, pass = model.userdata.pass });
                            mysqldatabase.index++;
                                return Content("new user "+model.userdata.username+"added");
                            }
                            else
                            {
                                return Content("No user found");
                            }
                        
                    }
                }
            }

            return View();

            
        }
    }
}
