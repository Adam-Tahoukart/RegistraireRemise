using PFI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class CoursesController : Controller
    {
        [UserAccess(Access.ReadOnly)]
        public ActionResult Index(string search = "")
        {
            Session["lastController"] = "Courses";
            Session["lastAction"] = "Index";

            ViewBag.Search = search;
            return View(FilterCourses(search));
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult GetCoursesList(string search = "")
        {
            return PartialView("_CoursesList", FilterCourses(search));
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult Details(int id)
        {
            Course course = DB.Courses.Get(id);
            if (course == null) return RedirectToAction("Index");
            return View(course);
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult GetCourseDetails(int id)
        {
            Course course = DB.Courses.Get(id);
            if (course == null) return HttpNotFound();
            return PartialView("_CourseDetails", course);
        }

        [UserAccess(Access.ReadWrite)]
        public ActionResult Create()
        {
            return View();
        }

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

        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(int id)
        {
            Course course = DB.Courses.Get(id);
            if (course == null) return RedirectToAction("Index");
            ViewBag.Registrations = course.NextSessionStudentsToSelectList();
            ViewBag.Students = Course.AllStudentsToSelectList();
            return View(course);
        }

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

        private List<Course> FilterCourses(string search)
        {
            var courses = DB.Courses.ToList();

            if (!string.IsNullOrEmpty(search))
                courses = courses.Where(c => c.Title.ToLower().Contains(search.ToLower()) || c.Code.ToLower().Contains(search.ToLower())).ToList();

            return courses;
        }
    }
}
