using System.ComponentModel.DataAnnotations;

namespace Portfolyo.Areas.Writer.Models
{
    public class UserRegisterViewModel
    {
        [Required(ErrorMessage = "Lütfen adınızı yazın.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Lütfen soyadınızı yazın.")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Lütfen profil resmi url'nizi yazın.")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage = "Lütfen kullanıcı adınızı yazın.")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi yazın.")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Lütfen şifrenizi tekrar yazın.")]
        [Compare("Password", ErrorMessage = "Şifreler uyuşmuyor.")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage = "Lütfen e-postanızı yazın.")]
        public string Mail { get; set; }
    }
}
