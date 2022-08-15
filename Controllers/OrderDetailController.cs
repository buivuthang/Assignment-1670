using Assignment.Data;
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
        public IActionResult Index()
        {
            return View(context.OrderDetail.ToList());
        }
    }
}
