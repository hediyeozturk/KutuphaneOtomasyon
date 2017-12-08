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
    public class MyContext:IdentityDbContext
    {
        public MyContext():base("name=Baglanti")
        {

        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<IdentityUser>()
                .ToTable("Kullanici", "dbo").Property(p => p.Id).HasColumnName("KullaniciID");
            modelBuilder.Entity<Kullanici>()
                .ToTable("Kullanici", "dbo").Property(p => p.Id).HasColumnName("KullaniciID");
        }

        public virtual DbSet<Uye> Uyeler { get; set; }
        public virtual DbSet<Kitap> Kitaplar { get; set; }
        public virtual DbSet<Odunc> Oduncler { get; set; }
        public virtual DbSet<Yazar> Yazarlar { get; set; }
        public virtual DbSet<Kategori> Kategoriler { get; set; }

    }
}
