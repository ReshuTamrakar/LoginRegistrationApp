using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginRegistrationApp.Controllers
{
    public class RegistrationController : Controller
    {
        // GET: Registration
        public ActionResult Reg()
        {
            return View();
        }


        public ActionResult SaveReg()
        {
            int sRegId = Convert.ToInt32(Request.Form["RegId"]);
            string sName = Request.Form["Name"];
            string sUsername = Request.Form["Username"];
            string sPassword = Request.Form["Password"];
            ViewBag.sRegId = sRegId;
            ViewBag.sName = sName;
            ViewBag.sUsername = sUsername;
            ViewBag.sPassword = sPassword;
            Session["username"] = sUsername;
            Session["password"] = sPassword;
            return View();

        }
        public ActionResult LoginPage()
        {
            return View();
        }
        public ActionResult Log()
        {
            string nUserName = Request.Form["UserName"];
            string nPassword = Request.Form["Password"];
            string sUsername = Session["username"].ToString();
            string sPassword = Session["password"].ToString();
            if (string.Compare(sUsername, nUserName) == 0 && string.Compare(sPassword, nPassword) == 0)

                ViewBag.message = "login success";
else
ViewBag.message = "login fail";
            return View();
        }
    }
}