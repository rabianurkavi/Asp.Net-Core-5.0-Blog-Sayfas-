using BusinessLayer.Concrete;
using CoreDemo.Areas.Admin.Models;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EntityLayer.Concrete;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class WriterController : Controller
    {
        WriterManager writerManager = new WriterManager(new EfWriterDal());
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GetWriterById(int writerid)
        {
            //var findwriters = writers.FirstOrDefault(x => x.WriterId == writerid);
            var findwriter = writerManager.GetById(writerid);
            var jsonWriters = JsonConvert.SerializeObject(findwriter);
            return Json(jsonWriters);
        }
        public IActionResult WriterList()
        {
            var jsonW = writerManager.GetList();
            var jsonWriters2= JsonConvert.SerializeObject(jsonW);
           //var jsonWriters = JsonConvert.SerializeObject(writers);//json formatına çevirmek
            return Json(jsonWriters2);
        }
        [HttpPost]
        public IActionResult AddWriter(Writer writer)
        {
            writer.WriterStatus = true;
            writerManager.TAdd(writer);
            //writerManager.TAdd(writer);
            var jsonWriters = JsonConvert.SerializeObject(writer);
            return Json(jsonWriters);
        }
        public IActionResult DeleteWriter(int id)
        {
            var writer = writerManager.GetById(id);
            writerManager.TDelete(writer);
            return Json(writer);
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
