using System.ComponentModel.DataAnnotations;
namespace LeeAllenFarm_Trucking.ViewModels
{
    public class ClientLoginViewModel
    {
        [Required, MaxLength(256), EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }
        [Required, MinLength(6), MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
        [Required, MinLength(6), MaxLength(20)]
        [DataType(DataType.Password)]
        [Display(Name = "Confirm Password")]
        [Compare("Password", ErrorMessage = "Password not match")]
        public string ConfirmPassword { get; set; }
    }
}
