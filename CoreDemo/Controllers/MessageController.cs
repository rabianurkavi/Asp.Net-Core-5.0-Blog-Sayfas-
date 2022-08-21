using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
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
        Context context = new Context();
        [AllowAnonymous]
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = message2Manager.GetInboxListByWriter(writerId);
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
