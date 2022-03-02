using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
            if (writer.WriterPassword == passwordCoupling)
            {
                writer.WriterStatus = true;
                writer.WriterAbout = "deneme test";
                writerManager.WriterAdd(writer);
                return RedirectToAction("Index", "Blog");
            }
            else
            {
                ModelState.AddModelError("WriterPassword", "Girdiğiniz şifreler eşleşmedi.Tekrar deneyin...");
            }
            return View();
                
        }
    }
}
