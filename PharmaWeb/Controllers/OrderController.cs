using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PharmaWeb.Data;
using PharmaWeb.Helpers;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;
using PharmaWeb.Service;
using System.Diagnostics;

namespace PharmaWeb.Controllers
{
    public class OrderController : Controller
    {
        private readonly IProductService _productService;
        private readonly IOrderService _orderService;
        private readonly UserManager<ApplicationUser> _userManager;


        public OrderController(IProductService productService, IOrderService orderService, UserManager<ApplicationUser> userManager)
        {
            _productService = productService;
            _orderService = orderService;
            _userManager = userManager;
        }

        [Authorize]
        //Create command & fill with info
        public async Task<IActionResult> CheckOut()
        {
            CreateCheckOutCommand cmd = new CreateCheckOutCommand();

            await PopulateViewModel(cmd);

            return View(cmd);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize]
        public async Task<IActionResult> CheckOut(CreateCheckOutCommand cmd)
        {
            await PopulateViewModel(cmd);

            if (ModelState.IsValid)
            {
                int id = _orderService.CreateOrder(cmd);

                foreach (CartLine cl in cmd.CartLines)
                {
                    Trace.WriteLine(" Product ID = " + cl.Product.Id);

                    //Control if there is stock for the product

                    if (_orderService.UpdateStock(cl.Product.Id, cl.Quantity) && cl.Quantity != 0)
                    {
                        _orderService.CreateOrderLine(cl, id);
                        HttpContext.Session.Remove("product");
                        return RedirectToAction("Succes");
                    }
                    else
                    {
                        return RedirectToAction("Error");
                    }
                }

            }

            return View(cmd);
        }

        public IActionResult Succes()
        {
            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

        //  Adjust stock of a certain product after an order
        public int UpdateStock(int id, int buyedQuantity)
        {
            Product product = _productService.GetProductById(id);
            int newStock;
            if (product.Stock >= buyedQuantity)
            {
                newStock = (product.Stock - buyedQuantity);

                return newStock;
            }
            return (product.Stock);

        }


        public IActionResult Index()
        {
            return View();
        }

        private async Task PopulateViewModel(CreateCheckOutCommand cmd)
        {
            //Get current product
            ShoppingCart cart = SessionHelper.GetObjectFromJson<ShoppingCart>(HttpContext.Session, "product");

            //Get current user
            ApplicationUser user = await _userManager.GetUserAsync(HttpContext.User);

            cmd.UserId = user.Id;
            Trace.WriteLine(cmd.UserId);
            cmd.FirstName = user.FirstName;
            cmd.LastName = user.LastName;
            cmd.CartLines = cart.CartLines;

        }


    }
}
