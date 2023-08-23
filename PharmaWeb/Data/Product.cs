using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Data
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Product number")]
        [Required(ErrorMessage = "Description is required.")]
        public string Productnumber { get; set; }

        [Display(Name = "Price")]
        [Required(ErrorMessage = "Productnumber is required.")]
        [Range(0.0, double.MaxValue, ErrorMessage = "Price must be more than 0")]
        public double Price { get; set; }

        [Required(ErrorMessage = "Stock is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Stock must be more than 0")]
        public int Stock { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description is required.")]
        public string Dscription { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Required(ErrorMessage = "Please choose product image")]
        [Display(Name = "Picture of product")]
        public string Image { get; set; }

        public bool IsDeleted { get; set; }


    }
}
