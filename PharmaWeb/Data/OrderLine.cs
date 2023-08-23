using PharmaWeb.Models;
using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Data
{
    public class OrderLine
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Product Products { get; set; }

        [Required]
        public int ProductId { get; set; }

        [Required]
        public int Quantity { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public Order Order { get; set; }

        [Required]
        public int OrderId { get; set; }

        //Default constructor
        public OrderLine()
        {
        }

        public OrderLine(int productId, int qty, double price, int orderId)
        {
            ProductId = productId;
            Quantity = qty;
            Price = price;
            OrderId = orderId;
        }
    }
}
