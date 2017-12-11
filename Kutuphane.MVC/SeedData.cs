using Kutuphane.BL.AccountRepository;
using Kutuphane.ENT.IdentityModel;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kutuphane.MVC
{
    public class SeedData
    {
        public static void Seed()
        {
            const string roleName = "Admin";
            var roleManager = MemberShipTools.NewRoleManager();
            var role = roleManager.FindByName(roleName);
            if (role == null)
            {
                role = new Rol() { Name = "Admin", Aciklama = "Site Yöneticisi" };
                roleManager.Create(role);
            }
            const string roleName2 = "User";
            role = roleManager.FindByName(roleName2);
            if (role == null)
            {
                role = new Rol() { Name = "User" };
                roleManager.Create(role);
            }
            const string roleName3 = "Passive";
            role = roleManager.FindByName(roleName3);
            if (role == null)
            {
                role = new Rol() { Name = "Passive" };
                roleManager.Create(role);
            }
        }

    }
}