using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvisingServices.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public ICollection<Session> Sessions { get; set; }


    }
}