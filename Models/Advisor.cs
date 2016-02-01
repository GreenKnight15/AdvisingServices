using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvisingServices.Models
{
    public class Advisor
    {
        public int AdvisorId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Department { get; set; }
        public bool freedom { get; set; }
        public ICollection<Session> Sessions { get; set; }
    }
}