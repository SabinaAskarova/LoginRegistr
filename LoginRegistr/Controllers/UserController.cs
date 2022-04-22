using LoginRegistr.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace LoginRegistr.Controllers
{
    public class UserController : Controller
    {
        public static List<User> users = new List<User>();
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Registr(string username, string password, string email)
        {
            User user = new User()
            {
                Username = username,
                Password = password,
                Email = email
            };
            users.Add(user);

            return RedirectToAction("Index");
        }
        
        public IActionResult Login(string username,string password)
        {
            foreach(User user in users)
            {
                if(user.Username==username && user.Password == password)
                {
                    return View();
                }
            }

            return RedirectToAction("Error1");
        }
       public IActionResult Error1()
        {
            return View();
        }

        public IActionResult RegistrForm()
        {
            return View();
        }
    }
}
