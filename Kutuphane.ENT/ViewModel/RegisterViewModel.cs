using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.ViewModel
{
    public class RegisterViewModel
    {
        [Required]
        [Display(Name = "Ad")]
        public string Ad { get; set; }

        [Required]
        [Display(Name = "Soyad")]
        public string Soyad { get; set; }

        [Required]
        [Display(Name = "Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 5, ErrorMessage = "Şifreniz en az 5 karakter olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(20, MinimumLength =5, ErrorMessage ="Şifreniz en az 5 karakter olmalıdır")]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Password", ErrorMessage ="Şifreler uyuşmuyor")]
        public string SifreTekrar { get; set; }
    }
}
