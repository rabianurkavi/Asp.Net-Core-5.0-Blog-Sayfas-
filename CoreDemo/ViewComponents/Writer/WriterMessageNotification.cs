
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.Context;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Writer
{
    public class WriterMessageNotification:ViewComponent
    {
        Message2Manager messageManager = new Message2Manager(new EfMessage2Dal());
        Context context = new Context();
        public IViewComponentResult Invoke()
        {
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerId = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterId).FirstOrDefault();
            var message = context.Message2s.Where(x => x.ReceiverID == writerId).Count();
            string not;
            if(message==0)
            {
                ViewBag.messageNumber = "Henüz mesajınız yok.";
            }
            else
            {
                ViewBag.messageNumber = message + " Mesajınız var";
            }
            
            var values = messageManager.GetInboxListWriter(writerId);
            return View(values);
        }
    }
}
