using PharmaWeb.Data;

namespace PharmaWeb.Models.ViewModels
{
    public class CreateProductCommand : EditProductBase
    {
   
        public Product ToProduct()
        {

         //making a new product
            return new Product()
            {
               Name = Name,
               Price = Price,
               Dscription = Dscription,
               Productnumber = Productnumber,
               CategoryId = SelectedCategoryId.Value,
               Stock = Stock,
               Image = ImagePath

            };
        }

       
    }
}
