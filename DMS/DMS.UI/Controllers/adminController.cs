using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
       
        public ActionResult adindex()
        {
            return View();
        }
    }
}