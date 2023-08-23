using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;

namespace PharmaWeb.Service
{
    public interface IProductService
    {
        public IEnumerable<Product> GetAllProducts();
        public UpdateProductCommand GetProductForUpdate(int id);
        public IEnumerable<Category> GetAllCategory();

        public Product GetProductById(int id);

        public void UpdateProduct(UpdateProductCommand cmd);
        public int CreateProduct(CreateProductCommand cmd);

        public bool DeleteProduct(int id);

    }
}
