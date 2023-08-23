using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Data
{
    public class Appointment
    {
       [Key]
        public int AfspraakID { get; set; }

        [Display(Name = "Firstname")]

        public string FirstName { get; set; }

        [Display(Name = "Lastname")]
        public string LastName { get; set; }

        [Display(Name = "Birthdate")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [Display(Name = "Phone number")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Day of the appointment")]
        public WeekDays? WeekDays { get; set; }
        [Display(Name = "Session")]
        public DaysSession? DaysSession { get; set; }
        [Display(Name = "Reason of the test")]
        public Reasontest? Reasontest { get; set; }

        public bool NotARobot { get; set; }

        public bool IsDeleted { get; set; }
    }

    public enum WeekDays
    {
        Monday,     // 0
        Tuesday,    // 1
        Wednesday,  // 2
        Thursday,   // 3
        Friday     // 4
    }

    public enum DaysSession
    {
        Session1,   // 9AM-10AM
        Session2,   // 10AM-11AM
        Session3,  // 11AM-12PM
        Session4,  // 2PM-3PM
        Session5   // 3PM-4PM
    }

    public enum Reasontest
    {
        reason1,   // vacation departure
        reason2,   // symptoms
        reason3,  // hospitalization
    }
}
