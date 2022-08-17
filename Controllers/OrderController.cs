using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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
            Order c = new Order();
            if (ModelState.IsValid)
            {
                c.OrderDetailId = (int)TempData["OrderId"];
                c.Total = (int)TempData["Total"];
                context.Add(c);
                context.SaveChanges();
                TempData["Message"] = "Create Order Successfully !";
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            return View(context.Order.ToList());
        }
    }
}
