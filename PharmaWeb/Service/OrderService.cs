using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;
using System.Diagnostics;

namespace PharmaWeb.Service
{
    public class OrderService : IOrderService
    {
        private readonly ApplicationDbContext _context;
        private readonly IProductService _productService;


        public OrderService(ApplicationDbContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }

        //Create new order
        public int CreateOrder(CreateCheckOutCommand cmd)
        {
            Order order = cmd.ToOrder();
            
            order.UserId = cmd.UserId;

            Trace.WriteLine("USER ID = " + order.UserId);

            _context.Orders.Add(order);

            _context.SaveChanges();

            return order.Id;
        }
        
        //Create a new line for a command
        public void CreateOrderLine(CartLine line, int orderId)
        {
            OrderLine ol = new(line.Product.Id, line.Quantity, line.Product.Price, orderId);

            _context.OrderLines.Add(ol);

            _context.SaveChanges();
        }


        //Adjust stock of a certain product after an order
        public bool UpdateStock(int id, int qt)
        {
            Product product = _productService.GetProductById(id);
            if (product.Stock >= qt)
            {
                product.Stock = (product.Stock - qt);
                _context.Products.Update(product);
                _context.SaveChanges();

                return true;
            }
            return false;

        }



    }
}
