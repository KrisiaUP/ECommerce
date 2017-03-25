namespace ECommerce.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "Usuario", c => c.String());
            AddColumn("dbo.AspNetUsers", "Nombre", c => c.String());
            AddColumn("dbo.AspNetUsers", "AppellidoPaterno", c => c.String());
            AddColumn("dbo.AspNetUsers", "AppellidoMaterno", c => c.String());
            AddColumn("dbo.AspNetUsers", "Direccion", c => c.String());
            AddColumn("dbo.AspNetUsers", "Colonia", c => c.String());
            AddColumn("dbo.AspNetUsers", "Ciudad", c => c.String());
            AddColumn("dbo.AspNetUsers", "Estado", c => c.String());
            AddColumn("dbo.AspNetUsers", "CP", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "CP");
            DropColumn("dbo.AspNetUsers", "Estado");
            DropColumn("dbo.AspNetUsers", "Ciudad");
            DropColumn("dbo.AspNetUsers", "Colonia");
            DropColumn("dbo.AspNetUsers", "Direccion");
            DropColumn("dbo.AspNetUsers", "AppellidoMaterno");
            DropColumn("dbo.AspNetUsers", "AppellidoPaterno");
            DropColumn("dbo.AspNetUsers", "Nombre");
            DropColumn("dbo.AspNetUsers", "Usuario");
        }
    }
}
