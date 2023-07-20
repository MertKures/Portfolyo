using System.ComponentModel.DataAnnotations;

namespace Portfolyo.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen kullanıcı adınızı yazın.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi yazın.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar yazın.")]
        [Compare("Password", ErrorMessage = "Passwords do not match")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen e-postanızı yazın.")]
        public string Mail { get; set; }
    }
}
