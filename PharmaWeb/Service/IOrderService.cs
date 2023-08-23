using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;

namespace PharmaWeb.Service
{
    public interface IOrderService
    {
        public int CreateOrder(CreateCheckOutCommand cmd);

        public void CreateOrderLine(CartLine line, int id);

        public bool UpdateStock(int id, int quantity);

    }
}
