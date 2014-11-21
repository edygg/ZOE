namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangesInSurgery : DbMigration
    {
        public override void Up()
        {
            //DropForeignKey("dbo.Surgeries", "Doctor_UserId", "dbo.UserProfile");
            //DropForeignKey("dbo.Surgeries", "SurgeryType_Id", "dbo.SurgeryTypes");
            //DropIndex("dbo.Surgeries", new[] { "Doctor_UserId" });
            //DropIndex("dbo.Surgeries", new[] { "SurgeryType_Id" });
            AddColumn("dbo.Surgeries", "Doctor_UsersId", c => c.Int(nullable: false));
            AlterColumn("dbo.Surgeries", "SurgeryType_Id", c => c.Int(nullable: false));
            DropColumn("dbo.Surgeries", "Doctor_UserId");
            //DropTable("dbo.UserProfile");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
            AddColumn("dbo.Surgeries", "Doctor_UserId", c => c.Int());
            AlterColumn("dbo.Surgeries", "SurgeryType_Id", c => c.Int());
            DropColumn("dbo.Surgeries", "Doctor_UsersId");
            CreateIndex("dbo.Surgeries", "SurgeryType_Id");
            CreateIndex("dbo.Surgeries", "Doctor_UserId");
            AddForeignKey("dbo.Surgeries", "SurgeryType_Id", "dbo.SurgeryTypes", "Id");
            AddForeignKey("dbo.Surgeries", "Doctor_UserId", "dbo.UserProfile", "UserId");
        }
    }
}
