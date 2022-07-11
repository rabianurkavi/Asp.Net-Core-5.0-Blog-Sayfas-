using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class RegisterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Writer writer,string passwordCoupling)
        {
            WriterValidator wv = new WriterValidator();
            ValidationResult results = wv.Validate(writer);
            if(results.IsValid)
            {
                if (writer.WriterPassword == passwordCoupling)
                {
                    writer.WriterStatus = true;
                    writer.WriterAbout = "deneme test";
                    writerManager.TAdd(writer);
                    return RedirectToAction("Index", "Blog");
                }
                else
                {
                    ModelState.AddModelError("WriterPassword", "Girdiğiniz şifreler eşleşmedi.Tekrar deneyin...");
                }
            }
            else
            {
                foreach(var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            
            return View();
                
        }
    }
}
