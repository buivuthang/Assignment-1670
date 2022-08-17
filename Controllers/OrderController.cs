using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class OrderController : Controller
    {
        private ApplicationDbContext context;
        public OrderController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Create()
        {
            ClaimsPrincipal currentUser = this.User;
            var currentUserID = currentUser.FindFirst(ClaimTypes.NameIdentifier).Value;
            Order o = new Order();
            if (ModelState.IsValid)
            {
                o.UserId = currentUserID;
                context.Add(o);
                context.SaveChanges();
                TempData["OrderId"] = o.Id;
                return RedirectToAction("Create", "OrderDetail");
            }
            return RedirectToAction("Cart","Cart");
        }

        public IActionResult Index()
        {
            return View(context.Order.ToList());
        }
    }
}
