// Controleur pour gerer les cours
using PFI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class CoursesController : Controller
    {
        // Affiche la liste
        [UserAccess(Access.ReadOnly)]
        public ActionResult Index(string search = "")
        {
            Session["lastController"] = "Courses";
            Session["lastAction"] = "Index";

            var courses = DB.Courses.ToList();

            if (!string.IsNullOrEmpty(search))
                courses = courses.Where(c => c.Title.ToLower().Contains(search.ToLower()) || c.Code.ToLower().Contains(search.ToLower())).ToList();

            ViewBag.Search = search;
            return View(courses);
        }

        // Affiche les details
        [UserAccess(Access.ReadOnly)]
        public ActionResult Details(int id)
        {
            Course course = DB.Courses.Get(id);
            if (course == null) return RedirectToAction("Index");
            return View(course);
        }

        // Affiche le formulaire
        [UserAccess(Access.ReadWrite)]
        public ActionResult Create()
        {
            return View();
        }

        // Ajoute un nouveau cours apres validation des donnees
        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Create(Course course)
        {
            if (course.IsValid())
            {
                DB.Courses.Add(course);
                return RedirectToAction("Index");
            }
            ViewBag.Errors = course.ValidationErrors;
            return View(course);
        }

        // Affiche le formulaire
        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(int id)
        {
            Course course = DB.Courses.Get(id);
            if (course == null) return RedirectToAction("Index");
            ViewBag.Registrations = course.NextSessionStudentsToSelectList();
            ViewBag.Students = Course.AllStudentsToSelectList();
            return View(course);
        }

        // Modifie les infos
        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(Course course, List<int> selectedStudentsId)
        {
            if (course.IsValid())
            {
                DB.Courses.Update(course);
                course.UpdateRegistrations(selectedStudentsId);
                return RedirectToAction("Details", new { id = course.Id });
            }
            ViewBag.Errors = course.ValidationErrors;
            ViewBag.Registrations = DB.Courses.Get(course.Id).NextSessionStudentsToSelectList();
            ViewBag.Students = Course.AllStudentsToSelectList();
            return View(course);
        }

        // Supprime un element
        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Delete(int id)
        {
            Course course = DB.Courses.Get(id);
            if (course != null)
            {
                course.DeleteAllRegistrations();
                course.DeleteAllAllocations();
                DB.Courses.Delete(id);
            }
            return RedirectToAction("Index");
        }
    }
}