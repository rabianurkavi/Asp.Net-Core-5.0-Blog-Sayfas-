using CoreDemo.Models;
using DataAccessLayer.Concrete.Context;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserSignInViewModel user)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(user.username, user.password, false, true);//sondaki parametre belli bir süre yanlış giriş sonucu banlanmak
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    return RedirectToAction("Index", "Login");
                }
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index","Login");
        }
        public IActionResult AccessDenied()
        {
            return View();
        }
        //[HttpPost]
        //public async Task<ActionResult> Index(Writer writer)
        //{
        //    Context context = new Context();
        //    var dataValue = context.Writers.FirstOrDefault(x => x.WriterMail == writer.WriterMail && x.WriterPassword == writer.WriterPassword);
        //    if(dataValue!=null)
        //    {
        //        var claims = new List<Claim>
        //        {
        //            new Claim(ClaimTypes.Name,writer.WriterMail)
        //        };
        //        var useridentity = new ClaimsIdentity(claims, "a");
        //        ClaimsPrincipal principal = new ClaimsPrincipal(useridentity);
        //        await HttpContext.SignInAsync(principal);
        //        return RedirectToAction("Index", "Dashboard");
        //    }
        //    else
        //    {
        //        return View();
        //    }
        //    //Context context = new Context();
        //    //var dataValue = context.Writers.FirstOrDefault(x=>x.WriterMail==writer.WriterMail && x.WriterPassword== writer.WriterPassword);
        //    //if (dataValue != null)
        //    //{
        //    //    HttpContext.Session.SetString("username", writer.WriterMail);
        //    //    return RedirectToAction("Index", "Writer");
        //    //}
        //    //else
        //    //{
        //    //    return View();
        //    //}
        //}
    }
}
