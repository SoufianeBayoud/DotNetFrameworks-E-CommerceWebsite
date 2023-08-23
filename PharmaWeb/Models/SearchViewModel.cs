using Microsoft.AspNetCore.Mvc.Rendering;
using PharmaWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Models
{
    public class SearchViewModel
    {
        //Search class to find a specific appointment
        public List<Appointment> Appointements { get; set; }
        [Display(Name = "Lastname")]
        public bool LastNameFilter { get; set; }
        [Display(Name = "Firstname")]
        public bool FirstNamefilter { get; set; }

        //Name of the filters
        public string SearchString { get; set; }
    }
}
