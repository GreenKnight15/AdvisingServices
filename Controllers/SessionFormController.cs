using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AdvisingServices.Models;
using System.Web.Mvc;

namespace AdvisingServices.Controllers
{
    public class SessionFormController : Controller
    {
        AdvisingServices.Models.AdvisingContext db = new AdvisingServices.Models.AdvisingContext();
        // GET: SessionForm
        public ActionResult Index(int Id)
        {
            var session = db.Sessions.Find(Id);
            session.startTime = DateTime.Now;
            db.SaveChanges();
                                            
            return View(session);
        }
    }
}