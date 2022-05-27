using DMS.DAL.newDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class galleryController : Controller
    {
        newsEntities db = new newsEntities();
        // GET: gallery
        public ActionResult newsPage()
        {
            List<recentNew> all_data = db.recentNews.ToList();
            return View(all_data);
        }
    }
}