using PharmaWeb.Data;

namespace PharmaWeb.Models
{
    public class CartLine
    {

        public Product Product { get; set; }
        public int Quantity { get; set; }

        public CartLine()
        {

        }

        public CartLine(Product product, int quantity)
        {
            Product = product;
            Quantity = quantity;
        }

    }
}
