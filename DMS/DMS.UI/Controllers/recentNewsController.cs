using DMS.DAL.newDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DMS.Controllers
{
    public class recentNewsController : Controller
    {
        newsEntities db = new newsEntities();
        // GET: recentNews
        public ActionResult recentNewPage()
        {
            List<recentNew> all_data = db.recentNews.ToList();
            return View(all_data);
        }

    }
}