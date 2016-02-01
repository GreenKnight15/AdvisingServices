using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AdvisingServices.Models
{
    public class AdvisingContext: DbContext 
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Advisor> Advisors { get; set; }
        public DbSet<Session> Sessions { get; set; }

    }

}