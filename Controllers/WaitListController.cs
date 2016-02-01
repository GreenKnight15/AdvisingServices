using AdvisingServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvisingServices.Controllers
{
    public class WaitListController : Controller
    {
        AdvisingContext db = new AdvisingContext();
        // GET: WaitList
        public ActionResult Index()
        {
            var waiting = db.Sessions.ToList();
            waiting.ToList();
            return View(waiting);
        }

        [HttpPost]
        public ActionResult StudentForm(Student stu)
        {
            Session se = new Session();
            se.stu = stu;
            se.checkInTime = DateTime.Now;
            db.Sessions.Add(se);
            db.SaveChanges();
            return Redirect("/");
        }
        public ActionResult StudentForm()
        {
            return View();
        }

        public ActionResult StudentChoice()
        {
            return View();

        }
        public ActionResult CurrentStudent()
        {
            
            return View();
        }

    }
}