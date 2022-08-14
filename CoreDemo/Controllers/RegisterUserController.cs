using CoreDemo.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
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
            if (!userSignUpView.IsAcceptTheContract)
            {
                ModelState.AddModelError("IsAcceptTheContract",
                    "Sayfamıza kayıt olabilmek için gizlilik sözleşmesini kabul etmeniz gerekmektedir.");
                return View(userSignUpView);
            }
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = userSignUpView.Mail,
                    UserName = userSignUpView.UserName,
                    NameSurname = userSignUpView.NameSurname,
                };
                var result = await _userManager.CreateAsync(user, userSignUpView.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userSignUpView);
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(UserSignUpViewModel userSignUpView)
        {
            if (ModelState.IsValid)
            {
                AppUser user = new AppUser()
                {
                    Email = userSignUpView.Mail,
                    UserName = userSignUpView.UserName,
                    NameSurname = userSignUpView.NameSurname,
                };
                var result = await _userManager.CreateAsync(user, userSignUpView.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View(userSignUpView);
        }
    }
}
