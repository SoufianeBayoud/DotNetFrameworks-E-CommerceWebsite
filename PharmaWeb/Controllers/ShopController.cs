using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PharmaWeb.Data;
using PharmaWeb.Helpers;
using PharmaWeb.Models;
using PharmaWeb.Service;

namespace PharmaWeb.Controllers
{
    [Authorize]

    public class ShopController : Controller
    {
        private readonly IProductService _service;

        public ShopController(IProductService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            //Display cart
            ShoppingCart cart = SessionHelper.GetObjectFromJson<ShoppingCart>(HttpContext.Session, "product") ?? new ShoppingCart();

            return View(cart.CartLines);
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult AddToShop(int productId, int quantity)
        {
            //Add item to cart or update the quantity if the item already exists in the cart 
            Product pr = _service.GetProductById(productId);

            ShoppingCart cart = SessionHelper.GetObjectFromJson<ShoppingCart>(HttpContext.Session, "product");

            if (cart == null)
            {
                cart = new ShoppingCart();

            }

            //Find cart by product
            CartLine line = cart.CartLines.Where(c => c.Product.Id == productId).FirstOrDefault();

            if (line != null)
            {
                line.Quantity += quantity;
            }
            else
            {
             
                line = new CartLine(pr, quantity);
            
                cart.CartLines.Add(line);
            }

            //Save new cart in user session
            SessionHelper.SetObjectAsJson(HttpContext.Session, "product", cart);


            return RedirectToAction("Index");
        }


        //Add action to remove product from cart
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult RemoveFromShop(int id)
        {
            ShoppingCart cart = SessionHelper.GetObjectFromJson<ShoppingCart>(HttpContext.Session, "product");

            CartLine line = cart.CartLines.SingleOrDefault(x => x.Product.Id == id);

            cart.CartLines.Remove(line);

            SessionHelper.SetObjectAsJson(HttpContext.Session, "product", cart);

            return RedirectToAction("Index");
        }

        //TASK: add action to clear the shopping cart
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Clear()
        {
            HttpContext.Session.Remove("product");

            return RedirectToAction("Index");
        }
    }


}

