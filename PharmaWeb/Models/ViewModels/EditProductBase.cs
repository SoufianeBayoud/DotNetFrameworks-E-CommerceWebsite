using PharmaWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Models.ViewModels
{
    public class EditProductBase
    {
     
        [Required(ErrorMessage = "Name is required.")]
        [Display(Name = "Name of the product")]
        public string Name { get; set; }

        [Display(Name = "Product number")]
        [Required(ErrorMessage = "Product number is required.")]
        public string Productnumber { get; set; }

        [Required(ErrorMessage = "Price is required.")]
        [Display(Name = "Price")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be greater to 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Category is required.")]
        [Display(Name = "Category")]
        public int? SelectedCategoryId { get; set; }

        public IEnumerable<Category>? Categorys { get; set; }
        [Required(ErrorMessage = "Stock is required.")]
        [Display(Name = "Stock of the product")]
        public int Stock { get; set; }
        [Required(ErrorMessage = "Description is required.")]
        [Display(Name = "Description of the product")]
        public string Dscription { get; set; }


        [Required(ErrorMessage = "Please choose a image about the product")]
        [Display(Name = "Image of the product")]
        public IFormFile ProfileImage { get; set; }


        public string? ImagePath { get; set; }
    }
}
