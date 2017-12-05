using Kutuphane.ENT.IdentityModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.Model
{
    [Table("Odunc")]
    public class Odunc : BaseModel
    {
        public DateTime AlisTarihi { get; set; }
        public DateTime? TeslimTarihi { get; set; }
        [Required]
        public int KitapID { get; set; }
        [Required]
        public int UyeID { get; set; }
        [Required]
        public string KullaniciID { get; set; }

        [ForeignKey("KitapID")]
        public virtual Kitap Kitap { get; set; }

        [ForeignKey("UyeID")]
        public virtual Uye Uye { get; set; }

        [ForeignKey("KullaniciID")]
        public virtual Kullanici Kullanici { get; set; }
    }
}
