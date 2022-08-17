using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Mvc;
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

        [HttpPost]
        public IActionResult Make(int id, int quantity)
        {
            var orderdetail = new OrderDetail();
            var book = context.Book.Find(id); 
            orderdetail.OrderId = orderdetail.Id;
            orderdetail.Book = book;
            orderdetail.BookId = id;
            orderdetail.Quantity = quantity;
            orderdetail.Total = book.Price * quantity;
            context.OrderDetail.Add(orderdetail);
            book.Quantity -= quantity;
            context.Book.Update(book);
            context.SaveChanges();
            TempData["OrderId"] = orderdetail.Id;
            TempData["Total"] = orderdetail.Total;
            return RedirectToAction("Create", "Order");
        }
        public IActionResult Index()
        {
            return View(context.OrderDetail.ToList());
        }
    }
}
