using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.Model
{
    [Table("Kitaplar")]
    public class Kitap : BaseModel
    {
        [Required(ErrorMessage ="Bu alan zorunludur")]
        public string KitapAdi { get; set; }
        public long? Aciklama { get; set; }
        public int YazarID { get; set; }
        public int KategoriID { get; set; }
        public bool Rafta { get; set; } = true;

        [Required]
        [StringLength(17)]
        public string ISBN { get; set; }

        [ForeignKey("YazarID")]
        public virtual Yazar Yazar { get; set; }

        [ForeignKey("KategoriID")]
        public virtual Kategori Kategori { get; set; }
    }
}
