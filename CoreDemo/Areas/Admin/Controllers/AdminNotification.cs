using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
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
    public class AdminNotification : Controller
    {
        NotificationManager notificationManager = new NotificationManager(new EfNotificationDal());
        public IActionResult Index()
        {
            var values = notificationManager.GetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NotificationAdd()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NotificationAdd(Notification notification)
        {
            notification.NotificationStatus = true;
            notificationManager.TAdd(notification);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult NotificationUpdate(int id)
        {
            var notificationId=notificationManager.GetById(id);
            return View(notificationId);
        }
        [HttpPost]
        public IActionResult NotificationUpdate(Notification notification)
        {
            notificationManager.TUpdate(notification);
            return RedirectToAction("Index");
        }
        public IActionResult NotificationDelete(int id)
        {
            var value=notificationManager.GetById(id);
            if(value.NotificationStatus==true)
            {
                value.NotificationStatus = false;
                notificationManager.TUpdate(value);
            }
            else if(value.NotificationStatus==false)
            {
                value.NotificationStatus = true;
                notificationManager.TUpdate(value);
            }
            return RedirectToAction("Index");
        }
    }
}
