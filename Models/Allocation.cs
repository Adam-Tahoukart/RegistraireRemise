using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFI.Models
{
    public class Allocation : Record
    {
        public int TeacherId { get; set; }
        public int CourseId { get; set; }
        public int Year { get; set; }

        public Allocation()
        {
            Year = NextSession.Year;
        }

        [JsonIgnore]
        public Course Course => DB.Courses.Get(CourseId);
        [JsonIgnore]
        public Teacher Teacher => DB.Teachers.Get(TeacherId);
        [JsonIgnore]
        public bool IsNextSession => Year == NextSession.Year && NextSession.ValidSessions.Contains(Course.Session);
    }
}
