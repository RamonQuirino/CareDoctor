namespace CareDoctor.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TesteMigration : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Usuario");
            DropColumn("dbo.Usuario", "SD");
            AddColumn("dbo.Usuario", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Usuario", "ID");
            
        }
        
        public override void Down()
        {
            //AddColumn("dbo.Usuario", "SD", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Usuario");
            DropColumn("dbo.Usuario", "SD");
            //AddPrimaryKey("dbo.Usuario", "ID");
        }
    }
}
