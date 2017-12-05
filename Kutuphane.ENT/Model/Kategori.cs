using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.Model
{
    [Table("Kategori")]
    public class Kategori:BaseModel
    {
        [Required(ErrorMessage ="Bu alanı girmek zorunlu")]
        public string KategoriAd { get; set; }
        public int? UstKategoriID { get; set; }

        [ForeignKey("UstKategoriID")]
        public virtual Kategori UstKategori { get; set; }

        public virtual List<Kategori> AltKategori { get; set; } = new List<Kategori>();

        public virtual List<Kitap> Kitap { get; set; } = new List<Model.Kitap>();
    }
}
