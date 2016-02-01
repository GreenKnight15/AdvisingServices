using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AdvisingServices.Models
{
    public class Session
    {
        public int? SessionId { get; set; }
        public  int? AdvisorId { get; set; }
        public int StudentId { get; set; }
        public virtual Student stu { get; set; }
        public Advisor advisor { get; set; }
        public DateTime? startTime { get; set; }
        public DateTime checkInTime { get; set; }
        public DateTime? endTime { get; set; }
        public string notes { get; set; }
    }
}