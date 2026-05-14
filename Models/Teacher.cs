// Modele pour les profs
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Models
{
    public class Teacher : Record
    {
        public string Code { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Avatar { get; set; }
        public DateTime StartDate { get; set; }

        // Donne le nom complet
        [JsonIgnore]
        public string FullName => LastName + " " + FirstName;
        // Donne le texte affiche dans les listes
        [JsonIgnore]
        public string Caption => Code + " " + LastName + " " + FirstName;

        // Retourne toutes les affectations de cet enseignant
        [JsonIgnore]
        public List<Allocation> Allocations => DB.Allocations.ToList().Where(a => a.TeacherId == Id).ToList();
        // Retourne les affectations de cet enseignant pour la prochaine session
        [JsonIgnore]
        public List<Allocation> NextSessionAllocations => DB.Allocations.ToList().Where(a => a.TeacherId == Id && a.IsNextSession).ToList();
        // Retourne la liste des cours donnes par cet enseignant (toutes sessions)
        [JsonIgnore]
        public List<Course> Courses
        {
            get
            {
                var courses = new List<Course>();
                foreach (var allocation in Allocations.OrderBy(a => a.Course.Code))
                    courses.Add(allocation.Course);
                return courses;
            }
        }

        // Verifie les champs
        [JsonIgnore]
        public List<string> ValidationErrors
        {
            get
            {
                var errors = new List<string>();
                if (string.IsNullOrEmpty(FirstName)) errors.Add("Le prenom est obligatoire.");
                if (string.IsNullOrEmpty(LastName)) errors.Add("Le nom est obligatoire.");
                if (string.IsNullOrEmpty(Phone)) errors.Add("Le telephone est obligatoire.");
                return errors;
            }
        }

        // Verifie si c est la prochaine session
        public bool IsValid() => ValidationErrors.Count == 0;

        // Cree une liste pour un formulaire
        public SelectList NextSessionCoursesToSelectList()
        {
            var courses = new List<Course>();
            foreach (var allocation in NextSessionAllocations.OrderBy(a => a.Course.Code))
                courses.Add(allocation.Course);
            return SelectListUtilities<Course>.Convert(courses, "Caption");
        }

        // Supprime un element
        public void DeleteAllAllocations()
        {
            foreach (Allocation a in Allocations)
                DB.Allocations.Delete(a.Id);
        }

        // Supprime un element
        public void DeleteNextSessionAllocations()
        {
            foreach (Allocation a in NextSessionAllocations)
                DB.Allocations.Delete(a.Id);
        }

        // Met a jour les affectations de la prochaine session selon les cours selectionnes
        public void UpdateAllocations(List<int> selectedCoursesId)
        {
            DeleteNextSessionAllocations();
            if (selectedCoursesId != null)
                foreach (int courseId in selectedCoursesId)
                    DB.Allocations.Add(new Allocation { TeacherId = Id, CourseId = courseId });
        }
    }
}