using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic2:ViewComponent
    {
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = context.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.BlogTitle).Take(1).FirstOrDefault();
            ViewBag.v2 = context.Blogs.OrderByDescending(x => x.BlogId).Select(x => x.Writer.WriterName).Take(1).FirstOrDefault();
            
            return View();
        }
    }
}
