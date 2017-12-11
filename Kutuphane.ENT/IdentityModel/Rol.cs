using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.ENT.IdentityModel
{
    public class Rol : IdentityRole
    {
        [StringLength(200)]
        public string Aciklama { get; set; }
    }
}
