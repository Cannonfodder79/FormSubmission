using System;
using System.ComponentModel.DataAnnotations;

namespace FormSubmission.Models
{
    public class User
    {
        [Required (ErrorMessage ="First name must be at least 4 characters")]
        [MinLength(4)]
        [Display(Name="First Name")]
        public string FirstName { get; set; }

        [Required (ErrorMessage="Last name must be at least 4 characters")]
        [MinLength(4)]
        [Display(Name="Last Name")]
        public string LastName { get; set; }

        [Required (ErrorMessage="Age must be between 1-100")]
        [Range(1,100)]
        [Display(Name="Age")]
        public int Age { get; set; }

        [Required (ErrorMessage="Must be a valid email address")]
        [DataType(DataType.EmailAddress)]
        [Display(Name="Email Address")]
        public string Email { get; set; }

        [Required (ErrorMessage="Password BAD >:(")]
        [DataType(DataType.Password)]
        [Display(Name="Password")]
        public string Password { get; set; }
    }
}