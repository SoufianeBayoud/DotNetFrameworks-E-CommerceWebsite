using PharmaWeb.Data;
using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Models.ViewModels
{
    public class CreateAppointmentCommand
    {
        [Key]
        public int AfspraakID { get; set; }

        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "Firstname must be completed")]
        public string FirstName { get; set; }

        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "Firstname must be completed")]
        public string LastName { get; set; }

        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Birthdate must be completed")]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Phone number must be completed")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Day")]
        [Required(ErrorMessage = "Day must be completed")]
        public WeekDays? WeekDays { get; set; }
        [Display(Name = "Choice the session")]
        [Required(ErrorMessage = "Session must be completed")]
        public DaysSession? DaysSession { get; set; }
        [Display(Name = "Reason of your test")]
        [Required(ErrorMessage = "Reason must be completed")]
        public Reasontest? Reasontest { get; set; }

        [ExpectedValue(ErrorMessage = "You must accept the terms of use")]
        [Display(Name = "I agree to the Terms and Conditions")]
        public bool NotARobot { get; set; }


        // Method for making a new appointment
        public Appointment ToAppointment()
        {
            return new Appointment()
            {
                FirstName = FirstName,
                LastName = LastName,
                BirthDate = BirthDate,
                PhoneNumber = PhoneNumber,
                DaysSession = DaysSession,
                WeekDays = WeekDays,
                Reasontest = Reasontest,
                NotARobot = NotARobot,
                IsDeleted = false
            };
        }







    }
}
