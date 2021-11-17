using Models;
using NatusVinceno_websitebanhang_lhu18ct112.Areas.Code;
using NatusVinceno_websitebanhang_lhu18ct112.Areas.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NatusVinceno_websitebanhang_lhu18ct112.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(LoginModel model)
        {
            //var result = new AccountModel().Login(model.Username, model.Password);
            if(Membership.ValidateUser(model.Username,model.Password) && ModelState.IsValid)
            {
                //SessionHelper.SetSession(new UserSession() { Username = model.Username });
                FormsAuthentication.SetAuthCookie(model.Username, model.RememberMe);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ModelState.AddModelError("", "Incorrect username or password");
            }
            return View(model);
        }

        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Login");
        }
        
    }
}