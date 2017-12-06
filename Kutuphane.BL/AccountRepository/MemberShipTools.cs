using Kutuphane.ENT.IdentityModel;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Kutuphane.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutuphane.BL.AccountRepository
{
    public class MemberShipTools
    {
        public static UserStore<Kullanici> YeniKullaniciStore() => new UserStore<Kullanici>(new MyContext());

        public static UserManager<Kullanici> YeniKullaniciManager() => new UserManager<Kullanici>(YeniKullaniciStore());

        public static RoleStore<Rol> YeniRolStore() => new RoleStore<Rol>(new MyContext());

        public static RoleManager<Rol> YeniRolManager() => new RoleManager<Rol>(YeniRolStore());
    }
}
