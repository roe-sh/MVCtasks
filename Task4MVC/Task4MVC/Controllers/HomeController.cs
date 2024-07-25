using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using Task4MVC.Models;

namespace Task4MVC.Controllers
{
    public class HomeController : Controller
    {
        
            public ActionResult Index()
            {
                return View();
            }

            public ActionResult AboutUs()
            {
                return View();
            }

            public ActionResult ContactUs()
            {
            var model = new ContactUsViewModel
            {
                Submissions = (List<ContactUsViewModel>)TempData["Submissions"] ?? new List<ContactUsViewModel>()
            };
            return View(model);

        }
        [HttpPost]
        public ActionResult ContactUs(ContactUsViewModel model)
        {
            if (ModelState.IsValid)
            {
                var submissions = (List<ContactUsViewModel>)TempData["Submissions"] ?? new List<ContactUsViewModel>();
                submissions.Add(model);
                TempData["Submissions"] = submissions;

                return RedirectToAction("ContactUs");
            }
            return View(model);
        }

        [Authorize]
            public ActionResult Profile()
            {
                return View();
            }

            public ActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public ActionResult Login(LoginViewModel model)
            {
                if (ModelState.IsValid && model.Email == "rahaf@rahaf.com" && model.Password == "12345")
                {
                    FormsAuthentication.SetAuthCookie(model.Email, false);
                    return RedirectToAction("Index");
                }

                ModelState.AddModelError("", "Invalid login attempt.");
                return View(model);
            }

            public ActionResult Logout()
            {
                FormsAuthentication.SignOut();
                return RedirectToAction("Index");
            }
        }

    }