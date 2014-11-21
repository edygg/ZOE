namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CreateSurgeryType : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SurgeryTypes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(),
                        Horas = c.Int(nullable: false),
                        Minutos = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.SurgeryTypes");
        }
    }
}
