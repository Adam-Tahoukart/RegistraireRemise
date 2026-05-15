using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PFI.Models;

namespace PFI.Models
{
    public class Registration : Record
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public int Year { get; set; }

        public Registration()
        {
            Year = NextSession.Year;
        }

        [JsonIgnore]
        public Course Course => DB.Courses.Get(CourseId);
        [JsonIgnore]
        public Student Student => DB.Students.Get(StudentId);
        [JsonIgnore]
        public bool IsNextSession => Year == NextSession.Year && NextSession.ValidSessions.Contains(Course.Session);
    }
}
