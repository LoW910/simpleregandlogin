using System.ComponentModel.DataAnnotations;

namespace SimpleLoginRegistration.Models
{
    public class LogUser
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email Address")]
        public string LEmail {get;set;}

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string LPassword {get;set;}

    }
}