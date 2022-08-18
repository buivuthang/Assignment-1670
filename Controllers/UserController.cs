using Assignment.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Assignment.Controllers
{
    public class UserController : Controller
    {
        private ApplicationDbContext context;
        public UserController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }
        public IActionResult Index()
        {
            var user = context.Users.ToList();
            var userRoles = context.UserRoles.ToList();
            ViewBag.Roles = userRoles;
            return View(user);
        }
        public IActionResult UserOrder()
        {
            var user = context.Users.ToList();
            var order = context.Order.Include(o => o.OrderDetails).ToList();

            ViewBag.Order = order;
            return View(user);
        }
    }
}
