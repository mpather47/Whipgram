using System.ComponentModel.DataAnnotations;

namespace Cellogram.Models
{
    public class LoginViewModel
    {
        
        [Required]
        [ MaxLength(500)]
        [Display(Name = "Username")]
        public string UserName { get; set; }
        
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        [Display(Name = "Remember Me")]
        public bool RememberMe { get; set; }
    }

}