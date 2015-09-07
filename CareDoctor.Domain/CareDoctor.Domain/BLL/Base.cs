using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CareDoctor.Domain.BLL
{
    public abstract class Base
    {
        public Repository.CareDoctor _ctx { get; set; }
        public Base()
        {
            _ctx = new Repository.CareDoctor();
            _ctx.Database.CreateIfNotExists();
        }
        public Base(Repository.CareDoctor ctx)
        {
            _ctx = ctx;
            _ctx.Database.CreateIfNotExists();
        }
    }
}
