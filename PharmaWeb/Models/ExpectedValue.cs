using System.ComponentModel.DataAnnotations;

namespace PharmaWeb.Models
{
    public class ExpectedValue : ValidationAttribute
    {
        //Custom validation to check if the user has accepted the terms and conditions and that it is not a robot that makes an appointment
    
        public bool Result { get; set; }

        public override bool IsValid(object value)
        {
            return value != null && value is bool && (bool)value;
        }
    }
}
