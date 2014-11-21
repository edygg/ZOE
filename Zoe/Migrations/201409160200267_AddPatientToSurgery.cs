namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPatientToSurgery : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Surgeries", "Patient_Id", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Surgeries", "Patient_Id");
        }
    }
}
