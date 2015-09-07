namespace CareDoctor.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Teste2Migration : DbMigration
    {
        public override void Up()
        {
            AddPrimaryKey("dbo.Usuario", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Usuario");
        }
    }
}
