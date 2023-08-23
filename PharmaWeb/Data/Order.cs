using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Data
{
    public class Order
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        public int Zip { get; set; }

        [Required]
        public string City { get; set; }


        //Fk user
        public string UserId { get; set; }

        public ICollection<OrderLine> OrderLines { get; set; }

        //Default constructor
        public Order()
        {
        }
    }
}
