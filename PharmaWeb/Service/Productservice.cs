using Microsoft.EntityFrameworkCore;
using PharmaWeb.Data;
using PharmaWeb.Models;
using PharmaWeb.Models.ViewModels;

namespace PharmaWeb.Service
{
    public class Productservice : IProductService
    {
        private readonly ApplicationDbContext _context;

        public Productservice(ApplicationDbContext applicationDbContext)
        {
            _context = applicationDbContext;

        }

        //Show all products in a list
        public IEnumerable<Product> GetAllProducts()
        {
            return _context.Products.Include(x => x.Category).Where(x => !x.IsDeleted).ToList();
        }
        //Show all categories in a list
        public IEnumerable<Category> GetAllCategory()
        {
            return _context.Category.ToList();
        }

        //Find product before update
        public UpdateProductCommand GetProductForUpdate(int id)
        {
            Product pro = _context.Products.Include(x => x.Category).Where(x => x.Id == id && !x.IsDeleted).FirstOrDefault();
            if (pro == null)
            {
                return null;
            }

            return new UpdateProductCommand(pro);
        }

        //Find product with id
        public Product GetProductById(int id)
        {
            return _context.Products.Include(x => x.Category).Where(x => x.Id == id && !x.IsDeleted).SingleOrDefault();
        }

        //Update product
        public void UpdateProduct(UpdateProductCommand cmd)
        {
            Product toEdit = _context.Products.Find(cmd.Id);

            if (toEdit != null)
            {
                cmd.UpdateProduct(toEdit);
                _context.SaveChanges();
            }
        }

        //Create a new product
        public int CreateProduct(CreateProductCommand cmd)
        {
            Product pr = cmd.ToProduct();

            _context.Products.Add(pr);

            _context.SaveChanges();

            return pr.Id;
        }

        //Remove a product
        public bool DeleteProduct(int id)
        {
            Product toDelete = _context.Products.Find(id);

            if (toDelete == null)
            {
                return false;
            }
            toDelete.IsDeleted = true;
            _context.Products.Remove(toDelete);
            _context.SaveChanges();

            return true;
        }
    }
}
