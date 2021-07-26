using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        [Route("user/add")] ///user
        public IActionResult Add()
        {
            return View();
        }

        //[HttpGet]
        [HttpPost]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            if (newUser.Password == verify)
            {
                ViewBag.NewUser = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.NewUsername = newUser.Username;
                ViewBag.NewEmail= newUser.Email;
                ViewBag.Error = "Error: Passwords do not match";
                return View("Add");
            }
        }
    }
}
