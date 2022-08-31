using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
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
    public class AdminMessageController : Controller
    {
        Message2Manager message2Manager = new Message2Manager(new EfMessage2Dal());
        Context context = new Context();
        public IActionResult InBox()
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = message2Manager.GetInboxListByWriter(writerId);
            var valuesSend = message2Manager.GetSendBoxListByWriter(writerId).Count();
            var messageTotal = message2Manager.GetInboxListByWriter(writerId).Count();
            ViewBag.messageTotal = messageTotal;
            ViewBag.messageSendTotal = valuesSend;

            return View(values);
        }
        public IActionResult SendBox()
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var values = message2Manager.GetSendBoxListByWriter(writerId);
            var messageTotal= message2Manager.GetSendBoxListByWriter(writerId).Count();
            var messageInboxTotal = message2Manager.GetInboxListByWriter(writerId).Count();
            ViewBag.messageSendTotal = messageTotal;
            ViewBag.messageInboxTotal = messageInboxTotal;
            return View(values);
        }
        [HttpGet]
        public IActionResult ComposeMessage()
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var messageTotal = message2Manager.GetSendBoxListByWriter(writerId).Count();
            var messageInboxTotal = message2Manager.GetInboxListByWriter(writerId).Count();

            ViewBag.messageSendTotal = messageTotal;
            ViewBag.messageInboxTotal = messageInboxTotal;
            return View();
        }
        [HttpPost]
        public IActionResult ComposeMessage(Message2 message2)
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            message2.SenderID = writerId;
            message2.ReceiverID = 2;
            message2.MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            message2.MessageStatus = true;
            message2Manager.TAdd(message2);
            return RedirectToAction("SendBox");
        }
        public IActionResult MessageDetail(int id)
        {
            var query = from message in context.Message2s
                        join writer in context.Writers
                        on message.SenderID equals writer.WriterId
                        where message.MessageID == id
                        select new { writer.WriterMail };
            var queryData = query.SingleOrDefault();



            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var messageTotal = message2Manager.GetSendBoxListByWriter(writerId).Count();
            var messageInboxTotal = message2Manager.GetInboxListByWriter(writerId).Count();
           
            ViewBag.messageSendTotal = messageTotal;
            ViewBag.messageInboxTotal = messageInboxTotal;

            
            var messageId = message2Manager.GetById(id);
            //int receiverId = messageIdd.ReceiverID;
            //hatalı
            //var messageId = message2Manager.GetInboxListByWriter(id);
            ViewBag.vtc = queryData.WriterMail;
            return View(messageId);
        }
    }
}
