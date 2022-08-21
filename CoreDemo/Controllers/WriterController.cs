using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using CoreDemo.Models;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    [Authorize]
    public class WriterController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        Context context = new Context();

        public WriterController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            var userMail = User.Identity.Name;
            ViewBag.uM = userMail;

            var writerName = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            ViewBag.wN = writerName;
            return View();
        }
        public IActionResult WriterProfile()
        {
            return View();
        }
        [Authorize]
        public IActionResult WriterMail()
        {
            return View();
        }
        [AllowAnonymous]
        public IActionResult Test()
        {
            return View();
        }
        [AllowAnonymous]
        public PartialViewResult WriterNavbarPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public PartialViewResult WriterFooterPartial()
        {
            return PartialView();
        }
        [AllowAnonymous]
        public async Task<IActionResult> WriterEditProfile()
        {
            UserUpdateViewModel model = new UserUpdateViewModel();
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            model.mail = values.Email;
            model.imageurl = values.ImageUrl;
            model.username = values.UserName;
            model.namesurname = values.NameSurname;
            
            return View(model);
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> WriterEditProfile(UserUpdateViewModel model)
        {
            //WriterValidator validationRules = new WriterValidator();
            //ValidationResult results = validationRules.Validate(writer);
            //if(results.IsValid)
            //{
            //    writerManager.TUpdate(writer);
            //    return RedirectToAction("Index", "Dashboard");
            //}
            //else
            //{
            //    foreach(var item in results.Errors)
            //    {
            //        ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
            //    }
            //}
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            values.NameSurname = model.namesurname;
            values.Email = model.mail;
            values.ImageUrl = model.imageurl;
            values.UserName = model.username;
            values.PasswordHash = _userManager.PasswordHasher.HashPassword(values, model.password);
            var result = await _userManager.UpdateAsync(values);


            return RedirectToAction("Index", "Dashboard");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult WriterAdd()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult WriterAdd(AddProfileImage writer)
        {
            Writer writer1 = new Writer();
            if (writer.WriterImage != null)
            {
                var extension = Path.GetExtension(writer.WriterImage.FileName);
                var newImageName = Guid.NewGuid() + extension;
                var location = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/WriterImageFiles/", newImageName);
                var stream = new FileStream(location, FileMode.Create);
                writer.WriterImage.CopyTo(stream);
                writer1.WriterImage = newImageName;
            }
            writer1.WriterMail = writer.WriterMail;
            writer1.WriterName = writer.WriterName;
            writer1.WriterPassword = writer.WriterPassword;
            writer1.WriterAbout = writer.WriterAbout;
            writer1.WriterStatus = true;
            writerManager.TAdd(writer1);
            return RedirectToAction("Index", "Dashboard");
        }
    }
}
