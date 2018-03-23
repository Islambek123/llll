using DAL.Entity;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApi.Controllers
{
    public class LoginController : Controller
    {
        public ContentResult Login(User model)
        {
            EFContext context = new EFContext();
            string json = "";
            bool isAuth = false;
            User checkUSER = context.Users.FirstOrDefault(t => t.Email == model.Email && t.Password == model.Password);
            if (checkUSER != null)
            {
                isAuth = true;
                Session["UserEmail"] = model.Email;

            }
            json = JsonConvert.SerializeObject(
                new
                {
                    Auth = isAuth
                });
            return Content(json, "application/json");
        }
        [HttpGet]
        public ContentResult UserLogin()
        {
            string json = JsonConvert.SerializeObject(
                new
                {
                    UserLogin = (string)Session["UserEmail"]
                });
            return Content(json, "application/json");
        }
    }
}