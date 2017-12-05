using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.ViewModel
{
    public class ProfilePasswordViewModel
    {
        public ProfileViewModel ProfileViewModel { get; set; } = new ProfileViewModel();
        public PasswordViewModel PasswordViewModel { get; set; } = new PasswordViewModel();
    }
    public class ProfileViewModel
    {
        public string Id { get; set; }
        [Display(Name = "Ad")]
        [StringLength(25)]
        public string Ad { get; set; }
        [Required]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }
        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
       
    }
    public class PasswordViewModel
    {
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Eski Şifre")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Yeni Şifre")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Compare("NewPassword", ErrorMessage = "Şifreler Uyuşmuyor")]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Şifre Tekrar")]
        [DataType(DataType.Password)]
        public string NewPasswordConfirm { get; set; }

    }
}
