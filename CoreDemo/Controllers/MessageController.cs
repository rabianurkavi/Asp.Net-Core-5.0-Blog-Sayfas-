using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class MessageController : Controller
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Dal());
        [AllowAnonymous]
        public IActionResult InBox()
        {
            int id = 2;
            var values = message2Manager.GetInboxListByWriter(id);
            return View(values);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult MessageDetails(int id)
        {            
            var messageValue = message2Manager.GetById(id);
            return View(messageValue);
        }
    }
}
