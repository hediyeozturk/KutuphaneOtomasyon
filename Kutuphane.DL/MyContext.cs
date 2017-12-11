using Microsoft.AspNet.Identity.EntityFramework;
using Kutuphane.ENT.IdentityModel;
using Kutuphane.ENT.Model;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.DL
{
    public class MyContext:IdentityDbContext<Kullanici>
    {
        public MyContext():base("name=Baglanti")
        {

        }
    }
}
