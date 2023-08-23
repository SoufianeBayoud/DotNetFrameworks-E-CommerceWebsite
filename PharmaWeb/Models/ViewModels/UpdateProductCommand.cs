using PharmaWeb.Data;

namespace PharmaWeb.Models.ViewModels
{
    public class UpdateProductCommand : EditProductBase
    {
        private readonly IWebHostEnvironment webHostEnvironment;
        public int Id { get; set; }

        public UpdateProductCommand()
        {
            //default constructor needed for model-binding7

        }


        public UpdateProductCommand(Product product)
        {

            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            Dscription = product.Dscription;
            SelectedCategoryId = product.CategoryId;
            Productnumber = product.Productnumber;
            Stock = product.Stock;
            ImagePath = product.Image;


        }

        //Method for updating a product

        public void UpdateProduct(Product product)
        {
          
            product.Name = Name;
            product.Price = Price;
            product.Dscription = Dscription;
            product.CategoryId = SelectedCategoryId.Value;
            product.Productnumber = Productnumber;
            product.Stock = Stock;
            product.Image = ImagePath;


        }

    }
}
