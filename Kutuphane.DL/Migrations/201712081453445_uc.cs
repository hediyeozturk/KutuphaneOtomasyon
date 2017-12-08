namespace Kutuphane.DL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uc : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.AspNetUserClaims", "IdentityUser_Id", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserLogins", "IdentityUser_Id", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserRoles", "IdentityUser_Id", "dbo.Kullanici");
            DropIndex("dbo.AspNetUserClaims", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "IdentityUser_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "IdentityUser_Id" });
            DropColumn("dbo.AspNetUserClaims", "UserId");
            DropColumn("dbo.AspNetUserLogins", "UserId");
            DropColumn("dbo.AspNetUserRoles", "UserId");
            RenameColumn(table: "dbo.AspNetUserClaims", name: "IdentityUser_Id", newName: "UserId");
            RenameColumn(table: "dbo.AspNetUserLogins", name: "IdentityUser_Id", newName: "UserId");
            RenameColumn(table: "dbo.AspNetUserRoles", name: "IdentityUser_Id", newName: "UserId");
            DropPrimaryKey("dbo.AspNetUserLogins");
            DropPrimaryKey("dbo.AspNetUserRoles");
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.AspNetUserLogins", new[] { "LoginProvider", "ProviderKey", "UserId" });
            AddPrimaryKey("dbo.AspNetUserRoles", new[] { "UserId", "RoleId" });
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.Kullanici", "KullaniciID", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.Kullanici", "KullaniciID", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.Kullanici", "KullaniciID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.Kullanici");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.Kullanici");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropPrimaryKey("dbo.AspNetUserRoles");
            DropPrimaryKey("dbo.AspNetUserLogins");
            AlterColumn("dbo.AspNetUserRoles", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserLogins", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String());
            AddPrimaryKey("dbo.AspNetUserRoles", new[] { "UserId", "RoleId" });
            AddPrimaryKey("dbo.AspNetUserLogins", new[] { "LoginProvider", "ProviderKey", "UserId" });
            RenameColumn(table: "dbo.AspNetUserRoles", name: "UserId", newName: "IdentityUser_Id");
            RenameColumn(table: "dbo.AspNetUserLogins", name: "UserId", newName: "IdentityUser_Id");
            RenameColumn(table: "dbo.AspNetUserClaims", name: "UserId", newName: "IdentityUser_Id");
            AddColumn("dbo.AspNetUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUserClaims", "UserId", c => c.String());
            CreateIndex("dbo.AspNetUserRoles", "IdentityUser_Id");
            CreateIndex("dbo.AspNetUserLogins", "IdentityUser_Id");
            CreateIndex("dbo.AspNetUserClaims", "IdentityUser_Id");
            AddForeignKey("dbo.AspNetUserRoles", "IdentityUser_Id", "dbo.Kullanici", "KullaniciID");
            AddForeignKey("dbo.AspNetUserLogins", "IdentityUser_Id", "dbo.Kullanici", "KullaniciID");
            AddForeignKey("dbo.AspNetUserClaims", "IdentityUser_Id", "dbo.Kullanici", "KullaniciID");
        }
    }
}
