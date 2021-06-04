using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserSignUpWithValidation.Models;

namespace UserSignUpWithValidation.Controllers
{
    public class UserSignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult UserSignUP()
        {
            return View();
        }

        [HttpPost]
        public IActionResult UserSignUP(UserSignUpModel usermodel)
        {
            if(string.IsNullOrEmpty(usermodel.Name))
            {
                ModelState.AddModelError("Name", "Please Enter Name.");
            }
            if (string.IsNullOrEmpty(usermodel.UserName))
            {
                ModelState.AddModelError("UserName", "Please Enter User Name.");
            }
            if (string.IsNullOrEmpty(usermodel.Password))
            {
                ModelState.AddModelError("Password", "Please Enter Password.");
            }
            if (string.IsNullOrEmpty(usermodel.ConfirmPassword))
            {
                ModelState.AddModelError("ConfirmPassword", "Please Enter Confirm Password.");
            }
            if (string.IsNullOrEmpty(usermodel.Contact))
            {
                ModelState.AddModelError("Contact", "Please Enter Contact.");
            }
            if (string.IsNullOrEmpty(usermodel.Country))
            {
                ModelState.AddModelError("Country", "Please Enter Country.");
            }
            if (string.IsNullOrEmpty(usermodel.City))
            {
                ModelState.AddModelError("Country", "Please Enter City.");
            }
            if (string.IsNullOrEmpty(usermodel.Gender))
            {
                ModelState.AddModelError("Country", "Please Enter Gender.");
            }
            

            if (ModelState.IsValid)
            {
                return RedirectToAction("Message");
            }

            return View();
        }

        public IActionResult Message()
        {
            return View();
        }
        }
}
