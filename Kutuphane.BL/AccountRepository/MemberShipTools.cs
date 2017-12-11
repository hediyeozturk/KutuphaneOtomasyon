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
        public static UserStore<Kullanici> NewUserStore() => new UserStore<Kullanici>(new MyContext());
        public static UserManager<Kullanici> NewUserManager() => new UserManager<Kullanici>(NewUserStore());

        public static RoleStore<Rol> NewRoleStore() => new RoleStore<Rol>(new MyContext());
        public static RoleManager<Rol> NewRoleManager() => new RoleManager<Rol>(NewRoleStore());
    }
}
