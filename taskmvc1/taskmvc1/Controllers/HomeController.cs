using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace taskmvc1.Controllers
{
    public class HomeController : Controller
    {
       
        
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult About()
            {
                ViewBag.Message = "Hello its me";

                return View();
            }

            public ActionResult Contact()
            {
                ViewBag.Message = "meow meowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeowmeow";

                return View();
            }
            public ActionResult login()
            {

                return View();
            }
            public ActionResult register()
            {


                return View();
            }
        }
    }

