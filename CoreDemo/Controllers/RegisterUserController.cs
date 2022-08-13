using CoreDemo.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterUserController : Controller
    {
        private readonly UserManager<AppUser> _userManager;//readonly sadece okunabilir class seviyesinde tanımlanır sonradan değeri değiştirilemez
        public RegisterUserController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignUpViewModel userSignUpView)
        {
            if(ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = userSignUpView.Mail,
                    UserName = userSignUpView.UserName,
                    NameSurname = userSignUpView.NameSurname,
                };
                var result = await _userManager.CreateAsync(user, userSignUpView.Password);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach(var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userSignUpView);
        }
    }
}
