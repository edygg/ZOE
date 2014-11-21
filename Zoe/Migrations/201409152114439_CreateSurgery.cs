namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSurgery : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Surgeries",
                c => new
                {
                    Id = c.Int(nullable: false, identity: true),
                    Doctor_UserId = c.Int(nullable: false),
                    SurgeryType_Id = c.Int(nullable: false),
                    Costo = c.Double(nullable: false),
                    FechaInicio = c.DateTime(nullable: false),
                    FechaFinalizacion = c.DateTime(nullable: false),
                })
                .PrimaryKey(t => t.Id);
        }
        
        public override void Down()
        {
            DropTable("dbo.Surgeries");
        }
    }
}
