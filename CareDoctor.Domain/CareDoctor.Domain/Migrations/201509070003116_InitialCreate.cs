namespace CareDoctor.Domain.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        SD = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                        Login = c.String(nullable: false),
                        Senha = c.String(nullable: false),
                        EmpresaID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SD)
                .ForeignKey("dbo.Empresa", t => t.EmpresaID, cascadeDelete: true)
                .Index(t => t.EmpresaID);
            
            CreateTable(
                "dbo.Empresa",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Nome = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Usuario", "EmpresaID", "dbo.Empresa");
            DropIndex("dbo.Usuario", new[] { "EmpresaID" });
            DropTable("dbo.Empresa");
            DropTable("dbo.Usuario");
        }
    }
}
