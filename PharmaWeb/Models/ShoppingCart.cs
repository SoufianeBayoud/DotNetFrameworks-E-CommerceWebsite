namespace PharmaWeb.Models
{
    public class ShoppingCart
    {
        public List<CartLine> CartLines { get; set; }

        //User
        public ShoppingCart()
        {
            CartLines = new List<CartLine>();
        }
    }
}
