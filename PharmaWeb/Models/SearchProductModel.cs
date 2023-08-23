using Microsoft.AspNetCore.Mvc.Rendering;
using PharmaWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Models
{
    public class SearchProductModel
    {
        //Search class to find a specific product
        public List<Product> Products { get; set; }
        public SelectList Categories { get; set; }
        public int? ProductCategory { get; set; }
        public string SearchString { get; set; }

        //Name of the filters
        [Display(Name = "Name")]
        public bool NameFilter { get; set; }

        [Display(Name = "Productnumber")]
        public bool ProductNumberFilter { get; set; }

    }
}
