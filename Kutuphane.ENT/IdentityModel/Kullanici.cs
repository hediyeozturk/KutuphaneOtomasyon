using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.IdentityModel
{
    public class Kullanici : IdentityUser
    {
        [StringLength(25)]
        public string Ad { get; set; }
        [StringLength(35)]
        public string Soyad { get; set; }
        [Column(TypeName="smalldatetime")]
        public DateTime KayitTarihi { get; set; } = DateTime.Now;
        
    }
}
