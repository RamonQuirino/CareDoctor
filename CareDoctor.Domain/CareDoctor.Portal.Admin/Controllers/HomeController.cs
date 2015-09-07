using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CareDoctor.Portal.Admin.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //var clienteView = Mapper.Map<CareDoctor.Domain.Repository.Usuario,  >(cliente);
            return View();
        }
    }
}