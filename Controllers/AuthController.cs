using bussineslogic.Services;
using data.Models;
using data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models.Auth;

namespace WebApplication1.Controllers
{
    public class AuthController : Controller
    {
        private readonly UserService _userService;
        public AuthController()
        {
            _userService = new UserService();
        }
        // GET: Auth
        public ActionResult Login()
        {
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [Route("auth/register")]
        public ActionResult Register(RegisterViewModel data)
        {
            if(!ModelState.IsValid)
            {
                return View(data);
            }
            if(string.IsNullOrEmpty(data.Username))
            {
                ModelState.AddModelError("", "Username can not be null");
                return View(data);
            }
            if (string.IsNullOrEmpty(data.Password)&&(data.Password == data.ConfirmPassword))
            {
                ModelState.AddModelError("", "Passwords don't match");
                return View(data);
            }
            try
            {
                User newUser = new User();
                newUser.Email = data.Email;
                newUser.Password = data.Password;
                newUser.Username = data.Username;
                newUser.PhoneNumber = data.PhoneNumber;
                newUser.FullName = data.FullName;
                _userService.AddUser(newUser);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError("", $"{ex.Message}");
                return View(data);
            }
            return Redirect(Url.Action("index", "home"));
        }
    }
}