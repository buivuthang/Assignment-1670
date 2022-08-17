using Assignment.Data;
using Assignment.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.Controllers
{
    
    public class BookController : Controller
    {
        private ApplicationDbContext context;
        public BookController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        [Authorize(Roles = "StoreOwner")]   
        public IActionResult Index()
        {
            var books = context.Book.OrderByDescending(b => b.Id).ToList();
            return View(books);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult Store()
        {
            return View(context.Book.ToList());
        }

        [Authorize(Roles = "StoreOwner")]
        public IActionResult Delete(int id)
        {
            var book = context.Book.Find(id);
            context.Book.Remove(book);
            context.SaveChanges();
            TempData["Message"] = "Delete book successfully !";
            return RedirectToAction("Index");
        }

        [Authorize(Roles = "Admin, StoreOwner, Customer")]
        public IActionResult Detail(int id)
        {
            var book = context.Book.Include(b => b.Category) 
                                       .FirstOrDefault(c => c.Id == id);
            return View(book);
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = context.Category.ToList();
            return View();
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpPost]
        public IActionResult Create(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Add(book);
                context.SaveChanges();
                TempData["Message"] = "Add book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = context.Category.ToList();
            return View(context.Book.Find(id));
        }

        [Authorize(Roles = "StoreOwner")]
        [HttpPost]
        public IActionResult Edit(Book book)
        {
            if (ModelState.IsValid)
            {
                context.Update(book);
                context.SaveChanges();
                TempData["Message"] = "Edit book successfully !";
                return RedirectToAction(nameof(Index));
            }
            return View(book);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult PriceAsc()
        {
            var Books = context.Book.OrderBy(b => b.Price).ToList();
            return View("Store", Books);
        }

        [Authorize(Roles = "Customer")]
        public IActionResult PriceDesc()
        {
            var Books = context.Book.OrderByDescending(b => b.Price).ToList();
            return View("Store", Books);
        }

        [Authorize(Roles = "Customer")]
        [HttpPost]
        public IActionResult Search(string keyword)
        {
            var Books = context.Book.Where(b => b.Title.Contains(keyword)).ToList();
            return View("Store", Books);
        }


        [Route("/checkout")]
        public IActionResult CheckOut()
        {
            return View();
        }
    }
}
