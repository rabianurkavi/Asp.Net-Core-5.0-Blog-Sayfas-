using CoreDemo.Areas.Admin.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminRole : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public AdminRole(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRole()
        { 
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(RoleViewModel viewModel)
        {
           if(ModelState.IsValid)
            {
                AppRole role = new AppRole
                {
                    Name = viewModel.RoleName
                };
                var result = await _roleManager.CreateAsync(role);
                if(result.Succeeded)
                {
                    return RedirectToAction("Index");
                }
                foreach(var item in result.Errors)
                {
                    ModelState.AddModelError("", item.Description);
                }
            }
            return View(viewModel);
        }
    }
}
