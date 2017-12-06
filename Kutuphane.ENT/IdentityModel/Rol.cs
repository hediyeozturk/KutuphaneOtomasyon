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
    [Table("Rol")]
    public class Rol : IdentityRole
    {
        public string Aciklama { get; set; }
    }
}
