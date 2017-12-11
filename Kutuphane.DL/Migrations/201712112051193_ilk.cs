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
                .ForeignKey("dbo.AspNetUsers", t => t.KullaniciID, cascadeDelete: true)
                .ForeignKey("dbo.Uye", t => t.UyeID, cascadeDelete: true)
                .Index(t => t.KitapID)
                .Index(t => t.UyeID)
                .Index(t => t.KullaniciID);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Ad = c.String(maxLength: 25),
                        Soyad = c.String(maxLength: 35),
                        KayitTarihi = c.DateTime(nullable: false, storeType: "smalldatetime"),
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
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
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
                        Aciklama = c.String(maxLength: 200),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Odunc", "UyeID", "dbo.Uye");
            DropForeignKey("dbo.Odunc", "KullaniciID", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Odunc", "KitapID", "dbo.Kitaplar");
            DropForeignKey("dbo.Kitaplar", "YazarID", "dbo.Yazar");
            DropForeignKey("dbo.Kitaplar", "KategoriID", "dbo.Kategori");
            DropForeignKey("dbo.Kategori", "UstKategoriID", "dbo.Kategori");
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.Odunc", new[] { "KullaniciID" });
            DropIndex("dbo.Odunc", new[] { "UyeID" });
            DropIndex("dbo.Odunc", new[] { "KitapID" });
            DropIndex("dbo.Kitaplar", new[] { "KategoriID" });
            DropIndex("dbo.Kitaplar", new[] { "YazarID" });
            DropIndex("dbo.Kategori", new[] { "UstKategoriID" });
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Uye");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.Odunc");
            DropTable("dbo.Yazar");
            DropTable("dbo.Kitaplar");
            DropTable("dbo.Kategori");
        }
    }
}
