using FYPFinalCode.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Security.Claims;
using Microsoft.AspNetCore.Authorization;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FYPFinalCode.Controllers
{

    public class AccountController : Controller
    {
        private const string AUTHSCHEME = "UserSecurity";

        
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        public IActionResult TermsCon()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(Parent reg)
        {
            if (!ModelState.IsValid)
            {
                ViewData["Message"] = "Invalid Input";
                ViewData["MsgType"] = "warning";
                return View("Register");
            }
            else
            {


                string insert = @"INSERT INTO Parent (Parent_email, Parent_emailPass, Parent_entryPass, Parent_name, Parent_MobileNo, Parent_VC)
VALUES ('ab20@gmail.com',HASHBYTES('SHA1','{1}'),HASHBYTES('SHA1','{2}'), 'ABIGAIL TAN','8451 7896','54120')";
                if (DBUtl.ExecSQL(insert, reg.ParentEmail, reg.ParentEmailPass, reg.ParentEntryPass, reg.ParentName, reg.ParentMobileNo, reg.ParentVc) == 1)
                {
                    ViewData["Message"] = "You have successfully created an account";
                    ViewData["MsgType"] = "success";
                    return View("Register");
                }
                else
                {
                    ViewData["Message"] = " An account has been registered. Please login.";
                    ViewData["MsgType"] = "warning";
                }
                return View("Register");

            }
        }
        private FYPdbcontext _dbContext;

        public AccountController(FYPdbcontext dbContext)
        {
            _dbContext = dbContext;
        }

      
        public IActionResult PinNo()
        {

            return View();
        }


        [HttpPost]
        public IActionResult Homepage(int PinNo)
        {

            if (ModelState.IsValid)
            {
                DbSet<Parent> dbs = _dbContext.Parent;
                Parent pin = dbs.Where(mo => mo.ParentVc == PinNo).FirstOrDefault();

                if (pin != null)
                {
                    return View();
                }
                else
                {
                    TempData["Error"] = "Incorrect password";
                    return View("PinNo");
                }

            }
            else
            {
                TempData["Error"] = "Invalid information entered";
                return View("PinNo");
            }

        }

        [AllowAnonymous]
        public IActionResult StudentLogin(string returnUrl = null)
        {
            TempData["ReturnUrl"] = returnUrl;
            return View("StudentLogin");
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult StudentLogin(Parent user)
        {

            if (!AuthenticateUser(user.ParentEmail, user.ParentEmailPass, out ClaimsPrincipal principal))
            {
                ViewData["Message"] = "Incorrect Email or Password. Please retry.";
                ViewData["MsgType"] = "Warning";
                return View("StudentLogin");
            }
            else
            {
                HttpContext.SignInAsync(
                   AUTHSCHEME,
               principal, new AuthenticationProperties
               {
                   IsPersistent = false
               });
                {

                    if (TempData["returnURL"] != null)
                    {
                        string returnURL = TempData["returnURL"].ToString();
                        if (Url.IsLocalUrl(returnURL))
                            return Redirect(returnURL);
                    }

                    return RedirectToAction("Homepage", "Account");
                }
            }
        }

        [Authorize]
        public IActionResult UserLogout(string returnURL = null)
        {
            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            if (Url.IsLocalUrl(returnURL))
                return Redirect(returnURL);
            return RedirectToAction("Logout", "PulseVenture");
        }

        private bool AuthenticateUser(string email, string Pass, out ClaimsPrincipal principal)
        {
            principal = null;


            string sql = @"SELECT Parent_email, Parent_emailPass FROM Parent
WHERE Parent_email = '{0}' AND Parent_emailPass = HASHBYTES('SHA1', '{1}')";
            string select = String.Format(sql,email, Pass);
            DataTable ds = DBUtl.GetTable(select);

            if (ds.Rows.Count == 1)
            {
                principal = new ClaimsPrincipal(
                    new ClaimsIdentity(
                        new Claim[]
                        {
                            new Claim(ClaimTypes.Email, ds.Rows[0]["Parent_email"].ToString()),


                        },
                        "Basic"));
                return true;

            }
            return false;
        }
        public IActionResult Forbidden()
        {
            return View();
        }

        public IActionResult Homepage()
        {
            return View();
        }
    }

  
}

