namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddFieldToSurgery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surgeries", "OjosOperados", c => c.String());
            AddColumn("dbo.Surgeries", "AgudezaVisual", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surgeries", "AgudezaVisual");
            DropColumn("dbo.Surgeries", "OjosOperados");
        }
    }
}
