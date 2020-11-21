using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_RV.Controllers
{
    [Authorize(Roles = "Usuario")]
    public class UsuarioController : Controller
    {
        // GET: Usuario
        
        public ActionResult Usuario()
        {
            return View();
        }
    }
}