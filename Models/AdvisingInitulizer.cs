using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvisingServices.Models
{
    public class AdvisingInitulizer: DropCreateDatabaseIfModelChanges<AdvisingContext>
    {
        protected override void Seed(AdvisingContext context)
        {
            var students = new List<Student>
            {
                new Student {Fname="James",Lname="Ritter" },
                new Student { Fname = "Tom", Lname = "Roberts" }
            };

            foreach (var temp in students)
            {
                context.Students.Add(temp);
            }
            context.SaveChanges();

            var advisors = new List<Advisor>
            {
                new Advisor {Fname="Jeff",Lname="Babb", Department="CIDM", freedom=true},
                new Advisor { Fname = "Tommy", Lname = "Hirsch", Department="Finance", freedom=false}
            };

            foreach (var temp in advisors)
            {
                context.Advisors.Add(temp);
            }
            context.SaveChanges();
            var sessions = new List<Session>
            {
                new Session {checkInTime=DateTime.Now, stu=new Student{ Fname="Jeremi",Lname="Wade"} }
            };

            foreach (var temp in sessions)
            {
                context.Sessions.Add(temp);
            }

            context.SaveChanges();
        }
    }
}