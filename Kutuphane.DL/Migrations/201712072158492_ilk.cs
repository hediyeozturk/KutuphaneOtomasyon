namespace Kutuphane.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ilk : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategori",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(nullable: false),
                        UstKategoriID = c.Int(),
                        isActive = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategori", t => t.UstKategoriID)
                .Index(t => t.UstKategoriID);
            
            CreateTable(
                "dbo.Kitaplar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        KitapAdi = c.String(nullable: false, maxLength: 60),
                        Aciklama = c.Long(),
                        YazarID = c.Int(nullable: false),
                        KategoriID = c.Int(nullable: false),
                        Rafta = c.Boolean(nullable: false),
                        ResimYolu = c.String(),
                        ISBN = c.String(nullable: false, maxLength: 17),
                        isActive = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kategori", t => t.KategoriID, cascadeDelete: true)
                .ForeignKey("dbo.Yazar", t => t.YazarID, cascadeDelete: true)
                .Index(t => t.YazarID)
                .Index(t => t.KategoriID);
            
            CreateTable(
                "dbo.Yazar",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        YazarAdi = c.String(nullable: false),
                        Aciklama = c.Long(),
                        isActive = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Odunc",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AlisTarihi = c.DateTime(nullable: false),
                        TeslimTarihi = c.DateTime(),
                        KitapID = c.Int(nullable: false),
                        UyeID = c.Int(nullable: false),
                        KullaniciID = c.String(nullable: false, maxLength: 128),
                        isActive = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Kitaplar", t => t.KitapID, cascadeDelete: true)
                .ForeignKey("dbo.Kullanici", t => t.KullaniciID, cascadeDelete: true)
                .ForeignKey("dbo.Uye", t => t.UyeID, cascadeDelete: true)
                .Index(t => t.KitapID)
                .Index(t => t.UyeID)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.Kullanici",
                c => new
                    {
                        KullaniciID = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                        Ad = c.String(maxLength: 25),
                        Soyad = c.String(maxLength: 35),
                        KayitTarihi = c.DateTime(storeType: "smalldatetime"),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.KullaniciID)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kullanici", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.Kullanici", t => t.IdentityUser_Id)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                        IdentityUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.Kullanici", t => t.IdentityUser_Id)
                .Index(t => t.RoleId)
                .Index(t => t.IdentityUser_Id);
            
            CreateTable(
                "dbo.Uye",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 25),
                        Soyad = c.String(nullable: false, maxLength: 35),
                        TCNo = c.String(nullable: false, maxLength: 11),
                        isActive = c.Boolean(nullable: false),
                        KayitTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.Rol",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Aciklama = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetRoles", t => t.Id)
                .Index(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Rol", "Id", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserRoles", "IdentityUser_Id", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserLogins", "IdentityUser_Id", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserClaims", "IdentityUser_Id", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Odunc", "UyeID", "dbo.Uye");
            DropForeignKey("dbo.Odunc", "KullaniciID", "dbo.Kullanici");
            DropForeignKey("dbo.Odunc", "KitapID", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazar");
            DropForeignKey("dbo.Kitaplar", "KategoriID", "dbo.Kategori");
            DropForeignKey("dbo.Kategori", "UstKategoriID", "dbo.Kategori");
            DropIndex("dbo.Rol", new[] { "Id" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.Kullanici", "UserNameIndex");
            DropIndex("dbo.Odunc", new[] { "KullaniciID" });
            DropIndex("dbo.Odunc", new[] { "UyeID" });
            DropIndex("dbo.Odunc", new[] { "KitapID" });
            DropIndex("dbo.Kitaplar", new[] { "KategoriID" });
            DropIndex("dbo.Kitaplar", new[] { "YazarID" });
            DropIndex("dbo.Kategori", new[] { "UstKategoriID" });
            DropTable("dbo.Rol");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Uye");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.Kullanici");
            DropTable("dbo.Odunc");
            DropTable("dbo.Yazar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kategori");
        }
    }
}
