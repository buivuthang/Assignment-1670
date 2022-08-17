using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    public class OrderDetailController : Controller
    {
        private ApplicationDbContext context;
        public OrderDetailController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        public IActionResult Create()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString("cart");
            if (jsoncart != null)
            {
                var cart = JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
                foreach (var item in cart)
                {
                    OrderDetail od = new OrderDetail();
                    od.Quantity = item.quantity;
                    od.Total = item.quantity * item.book.Price;
                    od.OrderId = (int)TempData["OrderId"];
                    od.BookId = item.book.Id;
                    context.Add(od);
                }
                TempData["Message"] = "Create Order Successfully !";
                context.SaveChanges();
            }
            return RedirectToAction("Cart", "Cart");
        }
        public IActionResult Index()
        {
            return View(context.OrderDetail.ToList());
        }
    }
}
