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
    public class CartController : Controller
    {
        private ApplicationDbContext context;
        public CartController(ApplicationDbContext applicationDbContext)
        {
            context = applicationDbContext;
        }

        // Key lưu chuỗi json của Cart
        public const string CARTKEY = "cart";

        // Lấy cart từ Session (danh sách CartItem)
        List<CartItem> GetCartItems()
        {
            var session = HttpContext.Session;
            string jsoncart = session.GetString(CARTKEY);
            if (jsoncart != null)
            {
                return JsonConvert.DeserializeObject<List<CartItem>>(jsoncart);
            }
            return new List<CartItem>();
        }

        // Xóa cart khỏi session
        public void ClearCart()
        {
            var session = HttpContext.Session;
            session.Remove(CARTKEY);
        }

        // Lưu Cart (Danh sách CartItem) vào session
        void SaveCartSession(List<CartItem> ls)
        {
            var session = HttpContext.Session;
            string jsoncart = JsonConvert.SerializeObject(ls);
            session.SetString(CARTKEY, jsoncart);
        }

        // Thêm sản phẩm vào cart
        [Route("addcart/{bookid:int}", Name = "addcart")]
        public IActionResult AddToCart([FromRoute] int bookid)
        {

            var book = context.Book
                .Where(b => b.Id == bookid)
                .FirstOrDefault();
            if (book == null)
                return NotFound("No book!");

            // Xử lý đưa vào Cart ...
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);
            if (cartitem != null)
            {
                // Đã tồn tại, tăng thêm 1
                cartitem.quantity++;
            }
            else
            {
                //  Thêm mới
                cart.Add(new CartItem() { quantity = 1, book = book });
            }

            // Lưu cart vào Session
            SaveCartSession(cart);
            // Chuyển đến trang hiện thị Cart
            return RedirectToAction(nameof(Cart));
        }

        // Hiện thị giỏ hàng
        [Route("/cart", Name = "cart")]
        public IActionResult Cart()
        {
            return View(GetCartItems());
        }

        // Cập nhật
        [Route("/updatecart", Name = "updatecart")]
        [HttpPost]
        public IActionResult UpdateCart([FromForm] int bookid, [FromForm] int quantity)
        {
            // Cập nhật Cart thay đổi số lượng quantity ...
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);
            if (cartitem != null)
            {
                cartitem.quantity = quantity;
            }
            SaveCartSession(cart);
            // Trả về mã thành công (không có nội dung gì - chỉ để Ajax gọi)
            return Ok();
        }

        // xóa item trong cart
        [Route("/removecart/{bookid:int}", Name = "removecart")]
        public IActionResult RemoveCart([FromRoute] int bookid)
        {
            var cart = GetCartItems();
            var cartitem = cart.Find(b => b.book.Id == bookid);

            if (cartitem != null)
            {
                cart.Remove(cartitem);
            }

            SaveCartSession(cart);
            return RedirectToAction(nameof(Cart));
        }

        public IActionResult MakeOrder()
        {
            return RedirectToAction("Create", "Order");
        }


    }
}
