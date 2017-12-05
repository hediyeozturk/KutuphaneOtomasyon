using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.Model
{
    [Table("Uye")]
    public class Uye :BaseModel
    {

        [Required]
        [StringLength(25)]
        public string Ad { get; set; }
        [Required]
        [StringLength(35)]
        public string Soyad { get; set; }
        [Required]
        [StringLength(11)]
        public string TCNo { get; set; }

        public virtual List<Odunc> Odunc { get; set; } = new List<Odunc>();
    }
}
