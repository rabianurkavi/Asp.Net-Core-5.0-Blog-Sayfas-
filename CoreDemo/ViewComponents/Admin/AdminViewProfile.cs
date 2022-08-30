using DataAccessLayer.Concrete.Context;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Admin
{
    public class AdminViewProfile:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            Context context = new Context();
            var userName = User.Identity.Name;
            var userMail = context.Users.Where(x => x.UserName == userName).Select(y => y.Email).FirstOrDefault();
            var writerName = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterName).FirstOrDefault();
            var writerImage = context.Writers.Where(x => x.WriterMail == userMail).Select(y => y.WriterImage).FirstOrDefault();
            ViewBag.name = writerName;
            ViewBag.img = writerImage;
            var query = from userRoles in context.UserRoles
                        join roles in context.Roles
                        on userRoles.RoleId equals roles.Id
                        join users in context.Users
                        on userRoles.RoleId equals users.Id
                        select new { users.NameSurname, roles.Name } into data
                        group data by new { data.NameSurname, data.Name } into result
                        select new
                        {
                            result.Key.NameSurname,
                            result.Key.Name,
                        };
            var userId = context.Users.Where(x => x.UserName == userName).Select(t => t.Id).FirstOrDefault();
            var roleId = context.UserRoles.Where(x => x.UserId == userId).Select(t => t.RoleId).FirstOrDefault();
            var roleName = context.Roles.Where(x => x.Id == roleId).Select(t => t.Name).FirstOrDefault();
            ViewBag.roleName = roleName;
            return View();
        }
    }
}
