using CoreDemo.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin,Moderator")]
    public class ChartController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CategoryChart()
        {
            List<CategoryModel> list = new List<CategoryModel>();
            list.Add(new CategoryModel
            {
                categoryname = "Aile",
                categorycount = 5
            });
            list.Add(new CategoryModel
            {
                categoryname = "Tarih",
                categorycount = 7
            });
            list.Add(new CategoryModel
            {
                categoryname = "Haber",
                categorycount = 13
            });
            list.Add(new CategoryModel
            {
                categoryname = "Magazin",
                categorycount = 7
            });
            list.Add(new CategoryModel
            {
                categoryname = "Sanat",
                categorycount = 12
            });
            list.Add(new CategoryModel
            {
                categoryname = "Sağlık",
                categorycount = 8
            });
            list.Add(new CategoryModel
            {
                categoryname = "Eğitim",
                categorycount = 20
            });
            list.Add(new CategoryModel
            {
                categoryname = "Sinema",
                categorycount = 21
            });
            list.Add(new CategoryModel
            {
                categoryname = "Teknoloji",
                categorycount = 40
            });
            list.Add(new CategoryModel
            {
                categoryname = "Yazılım",
                categorycount = 35
            });
            list.Add(new CategoryModel
            {
                categoryname = "Spor",
                categorycount = 4
            });
            list.Add(new CategoryModel
            {
                categoryname = "Müzik",
                categorycount = 19
            });
            return Json(new { jsonlist = list });
        }
    }
}
