namespace CareDoctor.Domain.Repository
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity;
    using System.Linq;

    public class CareDoctor : DbContext
    {
        // Your context has been configured to use a 'CareDoctor' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CareDoctor.Domain.Repository.CareDoctor' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'CareDoctor' 
        // connection string in the application configuration file.
        public CareDoctor()
            : base("name=CareDoctor")
        {}
        
        
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Empresa> Empresa { get; set; }
        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Required(ErrorMessage = "ID não pode ser branco.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Login não pode ser branco.")]
        public string Login{ get; set; }

        [Required(ErrorMessage = "Senha não pode ser branco.")]
        public string Senha { get; set; }

        [Required(ErrorMessage = "EmpresaID não pode ser branco.")]
        public int EmpresaID { get; set; }

        [ForeignKey("EmpresaID")]
        public Empresa Empresa { get; set; }
    }

    [Table("Empresa")]
    public class Empresa {
        [Key]
        [Required(ErrorMessage = "ID não pode ser branco.")]
        public int ID { get; set; }

        [Required(ErrorMessage = "Nome não pode ser branco.")]
        public string Nome { get; set; }
    }
}