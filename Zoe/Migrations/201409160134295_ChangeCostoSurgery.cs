namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangeCostoSurgery : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Surgeries", "Costo", c => c.Double(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Surgeries", "Costo", c => c.Single(nullable: false));
        }
    }
}
