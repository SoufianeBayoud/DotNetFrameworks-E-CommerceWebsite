using PharmaWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Models.ViewModels
{
    public class CreateCheckOutCommand
    {

        [Required(ErrorMessage = "Please enter your first name!")]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter your last name!")]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Please enter your street!")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter your street number!")]
        public int Number { get; set; }

        [Required(ErrorMessage = "Please enter your zip code!")]
        public int Zip { get; set; }

        [Required(ErrorMessage = "Please enter the name of your city!")]
        public string City { get; set; }

        //user ID
        public string UserId { get; set; } = "";

        public List<CartLine> CartLines { get; set; } = new List<CartLine>();

       //making a new order
        public Order ToOrder()
        {
            return new Order()
            {
                FirstName = FirstName,
                LastName = LastName,
                Street = Street,
                Number = Number,
                Zip = Zip,
                City = City,
            };
        }

    }
}
