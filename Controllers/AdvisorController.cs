using AdvisingServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvisingServices.Controllers
{
    public class AdvisorController : Controller
    {
        AdvisingContext db = new AdvisingContext();
        // GET: Advisor
        public ActionResult Index()
        {
            var advisors = db.Advisors.ToList();
            return View(advisors);
        }
    }
}