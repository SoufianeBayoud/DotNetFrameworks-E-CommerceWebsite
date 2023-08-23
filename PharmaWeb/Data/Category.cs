using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Data
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
