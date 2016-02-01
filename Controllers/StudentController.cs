using AdvisingServices.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdvisingServices.Controllers
{
    public class StudentController : Controller
    {
        private AdvisingContext db = new AdvisingContext();
        // GET: WaitList
        public ActionResult Index()
        {
            var students = db.Students.ToList();           
                return View(students);
        }
    }
}