using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminContact : Controller
    {
        ContactManager contactManager = new ContactManager(new EfContactDal());
        public IActionResult Index()
        {
            var values = contactManager.GetList();
            return View(values);
        }
    }
}
