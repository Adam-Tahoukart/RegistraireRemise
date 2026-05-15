using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Models
{
    public class Student : Record
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [JsonIgnore]
        public string FullName => LastName + " " + FirstName;
        [JsonIgnore]
        public string Caption => Code + " " + LastName + " " + FirstName;
        [JsonIgnore]
        public int Year => int.Parse(Code.Substring(0, 4));

        [JsonIgnore]
        public List<Registration> Registrations => DB.Registrations.ToList().Where(r => r.StudentId == Id).ToList();
        [JsonIgnore]
        public List<Registration> NextSessionRegistrations => DB.Registrations.ToList().Where(r => r.StudentId == Id && r.IsNextSession).ToList();
        [JsonIgnore]
        public List<Course> Courses
        {
            get
            {
                var courses = new List<Course>();
                foreach (var registration in Registrations.OrderBy(r => r.Course.Code))
                    courses.Add(registration.Course);
                return courses;
            }
        }
        [JsonIgnore]
        public List<Course> NextSessionCourses
        {
            get
            {
                var courses = new List<Course>();
                foreach (var registration in NextSessionRegistrations.OrderBy(r => r.Course.Code))
                    courses.Add(registration.Course);
                return courses;
            }
        }

        [JsonIgnore]
        public List<string> ValidationErrors
        {
            get
            {
                var errors = new List<string>();
                if (string.IsNullOrEmpty(FirstName)) errors.Add("Le prenom est obligatoire.");
                if (string.IsNullOrEmpty(LastName)) errors.Add("Le nom est obligatoire.");
                if (string.IsNullOrEmpty(Email)) errors.Add("Le courriel est obligatoire.");
                else if (!Email.Contains("@")) errors.Add("Le courriel est invalide.");
                if (string.IsNullOrEmpty(Phone)) errors.Add("Le telephone est obligatoire.");
                if (DB.Students.ToList().Any(s => s.Email == Email && s.Id != Id))
                    errors.Add("Ce courriel est deja utilise.");
                return errors;
            }
        }

        public bool IsValid() => ValidationErrors.Count == 0;

        public SelectList NextSessionCoursesToSelectList()
        {
            return SelectListUtilities<Course>.Convert(NextSessionCourses, "Caption");
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

        public void UpdateRegistrations(List<int> selectedCoursesId)
        {
            DeleteNextSessionRegistrations();
            if (selectedCoursesId != null)
                foreach (int courseId in selectedCoursesId)
                    DB.Registrations.Add(new Registration { StudentId = Id, CourseId = courseId });
        }
    }
}
