using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name ="Kullanıcı Adı")]
        public string KullaniciAdi { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name ="Şifre")]
        public string Sifre { get; set; }
    }
}
