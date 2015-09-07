using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareDoctor.Domain.BLL
{
    public class Authentication : Base
    {
        public Repository.Usuario Authenticate(string login, string password)
        {
            var usuario = _ctx.Usuario.Where(u => u.ID == 1).FirstOrDefault();
            return usuario;

            //var empresa = new Repository.Empresa
            //{
            //    Nome = "CareNutri"
            //};
            //_ctx.Empresa.Add(empresa);
            //_ctx.SaveChanges();

            //var usuario = new Repository.Usuario();
            //usuario.Nome = "ramon";
            //usuario.Senha = "123";
            //usuario.Login = "1233";
            //usuario.EmpresaID = 1;
            //_ctx.Usuario.Add(usuario);
            //_ctx.SaveChanges();

            //return usuario;

            //_ctx 
        
        }
    }
}
