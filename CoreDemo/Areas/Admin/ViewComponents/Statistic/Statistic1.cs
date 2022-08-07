﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreDemo.Areas.Admin.ViewComponents.Statistic
{
    public class Statistic1:ViewComponent
    {
        BlogManager blogManager = new BlogManager(new EfBlogDal());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            ViewBag.cv=blogManager.GetList().Count();
            ViewBag.ms = context.Contacts.Count();
            ViewBag.cc = context.Comments.Count();
            string api = "6fd2dfcc6c9fce3cb2f9ff2aa57e7c56";
            string connection= "https://api.openweathermap.org/data/2.5/weather?q=ankara&mode=xml&lang=tr&units=metric&appid="+api;
            XDocument document = XDocument.Load(connection);
            ViewBag.havaDurumu = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
