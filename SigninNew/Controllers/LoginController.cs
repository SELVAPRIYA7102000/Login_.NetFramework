using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace SigninNew.Models
{
    namespace SigninNew.Controllers
    {
        public class LoginController : Controller
        {
            // GET: Login
            public ActionResult Index()
            {
                return View();
            }
            public ActionResult LoginDetail()
            {
                return View();
            }

            public ActionResult EmpView()
            {


                List<Teacher> teachers = new List<Teacher>();
                teachers.Add(new Teacher { TeacherId = 001, Code = "TT", Name = "Priya" });
                teachers.Add(new Teacher { TeacherId = 002, Code = "JT", Name = "Rathina kumar" });
                teachers.Add(new Teacher { TeacherId = 003, Code = "RT", Name = "Pavithra" });
                ViewBag.no1 = teachers;
                return View();
            }
            public ActionResult Success(Class1 user)
            {
               
                if (user.Name == "priya" && user.Password == 123)
                {
                    return RedirectToAction("EmpView");    
                    
                }
                else if(user.Name == null)
                {
                    ViewBag.name = "Incorrect Username or Fill the UserName Field";
                }
                else
                {
                    ViewBag.resultok = "Awesome";
                    ViewData["result"] = "Wonderfull";
                    TempData["Tempresult"] = "Excellent";
                }
                return View();
            }
        }
    }
}