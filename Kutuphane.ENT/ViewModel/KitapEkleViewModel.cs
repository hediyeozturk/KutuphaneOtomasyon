using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.ViewModel
{
    public class KitapEkleViewModel
    {
        [Required(ErrorMessage = "Bu alan zorunludur")]
        [StringLength(60)]
        public string KitapAdi { get; set; }

        public long? Aciklama { get; set; }

        [Required(ErrorMessage = "Bu alan zorunludur")]
        public int YazarID { get; set; }

        public int KategoriID { get; set; }
        public bool Rafta { get; set; } = true;
        [DataType(DataType.Url)]
        public string ResimYolu { get; set; }
        [Required]
        [StringLength(17)]
        public string ISBN { get; set; }
    }
}
