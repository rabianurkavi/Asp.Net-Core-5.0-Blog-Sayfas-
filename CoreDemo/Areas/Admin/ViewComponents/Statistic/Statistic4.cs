using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.adminName = context.Admins.Where(x => x.AdminID == 1).Select(y => y.Name).FirstOrDefault(); 
            ViewBag.adminImage = context.Admins.Where(x => x.AdminID == 1).Select(y => y.AdminImageURL).FirstOrDefault(); 
            return View();
        }
    }
}
