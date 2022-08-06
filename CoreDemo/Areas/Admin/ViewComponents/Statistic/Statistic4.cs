using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic4:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
