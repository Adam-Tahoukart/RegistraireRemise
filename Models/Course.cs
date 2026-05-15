using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Models
{
    public class Course : Record
    {
        public string Code { get; set; }
        public string Title { get; set; }
        public int Session { get; set; }

        [JsonIgnore]
        public string Caption => Code + " " + Title;

        [JsonIgnore]
        public List<Registration> Registrations => DB.Registrations.ToList().Where(r => r.CourseId == Id).ToList();
        [JsonIgnore]
        public List<Registration> NextSessionRegistrations => DB.Registrations.ToList().Where(r => r.CourseId == Id && r.IsNextSession).ToList();
        [JsonIgnore]
        public List<Student> Students
        {
            get
            {
                var students = new List<Student>();
                foreach (var registration in Registrations.OrderBy(r => r.Student.LastName))
                    students.Add(registration.Student);
                return students;
            }
        }

        [JsonIgnore]
        public List<Allocation> Allocations => DB.Allocations.ToList().Where(a => a.CourseId == Id).ToList();
        [JsonIgnore]
        public List<Allocation> NextSessionAllocations => DB.Allocations.ToList().Where(a => a.CourseId == Id && a.IsNextSession).ToList();

        [JsonIgnore]
        public List<string> ValidationErrors
        {
            get
            {
                var errors = new List<string>();
                if (string.IsNullOrEmpty(Code)) errors.Add("Le sigle est obligatoire.");
                if (string.IsNullOrEmpty(Title)) errors.Add("Le titre est obligatoire.");
                if (Session < 1 || Session > 6) errors.Add("La session doit etre entre 1 et 6.");
                if (DB.Courses.ToList().Any(c => c.Code == Code && c.Id != Id))
                    errors.Add("Ce sigle est deja utilise.");
                return errors;
            }
        }

        public bool IsValid() => ValidationErrors.Count == 0;

        public static SelectList NextSessionToSelectList()
        {
            var courses = DB.Courses.ToList()
                .Where(c => NextSession.ValidSessions.Contains(c.Session))
                .OrderBy(c => c.Session)
                .ToList();
            return SelectListUtilities<Course>.Convert(courses, "Caption");
        }

        public SelectList NextSessionStudentsToSelectList()
        {
            var students = NextSessionRegistrations
                .Select(r => r.Student)
                .OrderBy(s => s.LastName)
                .ToList();
            return SelectListUtilities<Student>.Convert(students, "Caption");
        }

        public static SelectList AllStudentsToSelectList()
        {
            var students = DB.Students.ToList().OrderBy(s => s.LastName).ToList();
            return SelectListUtilities<Student>.Convert(students, "Caption");
        }

        public void DeleteAllRegistrations()
        {
            foreach (Registration r in Registrations)
                DB.Registrations.Delete(r.Id);
        }

        public void DeleteNextSessionRegistrations()
        {
            foreach (Registration r in NextSessionRegistrations)
                DB.Registrations.Delete(r.Id);
        }

        public void UpdateRegistrations(List<int> selectedStudentsId)
        {
            DeleteNextSessionRegistrations();
            if (selectedStudentsId != null)
                foreach (int studentId in selectedStudentsId)
                    DB.Registrations.Add(new Registration { StudentId = studentId, CourseId = Id });
        }

        public void DeleteAllAllocations()
        {
            foreach (Allocation a in Allocations)
                DB.Allocations.Delete(a.Id);
        }
    }
}
