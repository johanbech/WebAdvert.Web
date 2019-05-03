using System.ComponentModel.DataAnnotations;

namespace WebAdvert.Web.Models.Accounts
{
    public class SignupModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name ="Email")]
        public string Email { get; set; }

        [Required]
        [Display(Name = "USername")]
        public string Username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [StringLength(6,ErrorMessage ="Password skal være mindst 6 tegn og med special tegn, stor og lille bogstaver, også med tal.")]
        [Display(Name ="Password")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Compare("Password",ErrorMessage ="Password er ikke ens.")]
        public string ConfirmPassword { get; set; }
    }
}
