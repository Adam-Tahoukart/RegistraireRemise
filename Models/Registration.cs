// Modele qui lie un etudiant a un cours
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

        // Met la bonne annee
        public Registration()
        {
            Year = NextSession.Year;
        }

        [JsonIgnore]
        // Donne le cours lie
        public Course Course => DB.Courses.Get(CourseId);
        [JsonIgnore]
        // Donne l etudiant lie
        public Student Student => DB.Students.Get(StudentId);
        [JsonIgnore]
        // Verifie si c est la prochaine session
        public bool IsNextSession => Year == NextSession.Year && NextSession.ValidSessions.Contains(Course.Session);
    }
}