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
        public int YazarID { get; set; }
        public bool Rafta { get; set; } = true;

        [ForeignKey("YazarID")]
        public virtual Yazar Yazar { get; set; }
    }
}
