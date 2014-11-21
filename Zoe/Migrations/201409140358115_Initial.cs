namespace Zoe.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Patients",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombres = c.String(),
                        Apellidos = c.String(),
                        Domicilio = c.String(),
                        TelefonoFijo = c.String(),
                        TelefonoCelular = c.String(),
                        Ciudad = c.String(),
                        Departamento = c.String(),
                        Nacionalidad = c.String(),
                        Edad = c.Int(nullable: false),
                        EstadoCivil = c.String(),
                        NoHijos = c.Int(nullable: false),
                        Ocupacion = c.String(),
                        Observaciones = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Patients");
        }
    }
}
