using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult WriterList()
        {
            var jsonWriters = JsonConvert.SerializeObject(writers);//json formatına çevirmek
            return Json(jsonWriters);
        }
        public static List<WriterModel> writers = new List<WriterModel>
        {
            new WriterModel
            {
                WriterId=1,
                WriterName="Hüseyin"
            },
            new WriterModel
            {
                WriterId=2,
                WriterName="Mehmet"
            },
            new WriterModel
            {
                WriterId=3,
                WriterName="Serkan"
            },
            new WriterModel
            {
                WriterId=4,
                WriterName="Bünyamin"
            }
        };
    }
}
