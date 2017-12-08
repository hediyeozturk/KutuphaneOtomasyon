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
        [Display(Name = "TC Kimlik No")]
        [StringLength(11, ErrorMessage ="TC Kimlik No 11 haneli olmalıdır.")]
        public string TCNo { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 6, ErrorMessage = "Şifreniz en az 6 karakter olmalıdır!")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }

        [Required]
        [StringLength(20, MinimumLength =6, ErrorMessage ="Şifreniz en az 6 karakter olmalıdır")]
        [Display(Name = "Şifre Tekrar")]
        [Compare("Sifre", ErrorMessage ="Şifreler uyuşmuyor")]
        [DataType(DataType.Password)]
        public string SifreTekrar { get; set; }
    }
}
