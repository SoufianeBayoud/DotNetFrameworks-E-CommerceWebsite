using Microsoft.AspNetCore.Identity;

namespace PharmaWeb.Data
{
    public class ApplicationUser : IdentityUser
    {
        //Class for a custom user
        [PersonalData]
        public string FirstName { get; set; }

        [PersonalData]
        public string LastName { get; set; }

        [PersonalData]
        public DateTime BirthDate { get; set; }
    }
}
