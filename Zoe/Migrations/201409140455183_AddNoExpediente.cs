namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddNoExpediente : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Patients", "NoExpediente", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Patients", "NoExpediente");
        }
    }
}
