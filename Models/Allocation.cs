// Modele qui lie un prof a un cours
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

        // Met la bonne annee
        public Allocation()
        {
            Year = NextSession.Year;
        }

        [JsonIgnore]
        // Donne le cours lie
        public Course Course => DB.Courses.Get(CourseId);
        [JsonIgnore]
        // Donne le prof lie
        public Teacher Teacher => DB.Teachers.Get(TeacherId);
        [JsonIgnore]
        // Verifie si c est la prochaine session
        public bool IsNextSession => Year == NextSession.Year && NextSession.ValidSessions.Contains(Course.Session);
    }
}