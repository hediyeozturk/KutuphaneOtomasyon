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
        public virtual DbSet<Uye> Uye { get; set; }
        public virtual DbSet<Kitap> Kitap { get; set; }
        public virtual DbSet<Odunc> Odunc { get; set; }
        public virtual DbSet<Yazar> Yazar { get; set; }
        public virtual DbSet<Kategori> Kategori { get; set; }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>()
                .ToTable("Kullanici", "dbo").Property(p => p.Id).HasColumnName("KullaniciID");
            modelBuilder.Entity<Kullanici>()
                .ToTable("Kullanici", "dbo").Property(p => p.Id).HasColumnName("KullaniciID");


        }
    }
}
