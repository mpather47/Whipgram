using System.ComponentModel.DataAnnotations;

namespace Cellogram.Models
{
    public class LoginViewModel
    {
        
        [Required]
        [ MaxLength(500)]
        [Display(Name = "Email Address")]
        public string UserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Passwords must match")]
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }

        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }

}