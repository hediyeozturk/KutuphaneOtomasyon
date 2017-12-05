using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.Model
{
    public class BaseModel
    {
        [Key]
        public int ID { get; set; }
        public bool isActive { get; set; } = true;
        [Column(TypeName = "smalldatetime")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
    }
}
