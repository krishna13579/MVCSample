using MvcSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSample.Controllers
{
    public class AccountController : Controller
    {
<<<<<<< HEAD
       //Murugan - Test1 -comit1 - commit3
=======
       //Murugan - Test1 -comit1 - commit2
>>>>>>> c7f205b59611c80ecfd780e131701079f9da453b
        // GET: /Account/

        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Submit(string UserName , String Password)
        {
            if (UserName != "" && Password != "")
                return RedirectToAction("Index", "Home");
            else
                return View("Login");
            
        }
        [HttpPost]
        public JsonResult AjaxSubmit(AccountModel Obj)
        {
            JsonResult result = new JsonResult();
            string sample = string.Empty;
            if (Obj.UserName != null && Obj.Password != null)
            {
                result.Data = "Home";
                return result;
            }
            else
            {
                result.Data = "Login";
                return result;
            }
        }
       
    }
}
