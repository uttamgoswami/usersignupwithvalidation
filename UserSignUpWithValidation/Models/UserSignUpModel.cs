using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using UserSignUpWithValidation.Attributes;

namespace UserSignUpWithValidation.Models
{
    public class UserSignUpModel
    {
        [Required(ErrorMessage = "Please enter a name.")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter username.")]
        [Display(Name = "UserName")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Please enter your password.")]
        [Display(Name = "Password")]
        public string Password { get; set; }
        
        [Required(ErrorMessage = "Please enter your confirm password.")]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage ="Confirm password doesn't match.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Please enter contact details.")]
        [Display(Name = "Contact")]
        [RegularExpression("^[6,7,8,9]\\{9}$", ErrorMessage ="Please enter a valid contact number.")]
        public string Contact { get; set; }

        [Required(ErrorMessage = "Please Enter country name.")]
        [Display(Name = "Country")]
        public string Country { get; set; }

        [Required(ErrorMessage = "Please select city.")]
        [Display(Name = "City")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please select a gender.")]
        [Display(Name = "Gender")]
        public string Gender { get; set; }

        [ValidateCheckBox(ErrorMessage = "Please accept terms.")]
        public bool AcceptTerms { get; set; }

    }
}
