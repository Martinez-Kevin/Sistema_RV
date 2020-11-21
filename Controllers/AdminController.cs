using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sistema_RV.Controllers
{
    [Authorize (Roles = "Administrador")]
    public class AdminController : Controller
    {
        // GET: Admin
        
        public ActionResult Admin()
        {
            return View();
        }
    }
}