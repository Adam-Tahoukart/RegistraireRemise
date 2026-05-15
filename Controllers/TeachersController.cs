using PFI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class TeachersController : Controller
    {
        [UserAccess(Access.ReadOnly)]
        public ActionResult Index(string search = "")
        {
            Session["lastController"] = "Teachers";
            Session["lastAction"] = "Index";

            ViewBag.Search = search;
            return View(FilterTeachers(search));
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult GetTeachersList(string search = "")
        {
            return PartialView("_TeachersList", FilterTeachers(search));
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult Details(int id)
        {
            Teacher teacher = DB.Teachers.Get(id);
            if (teacher == null) return RedirectToAction("Index");
            return View(teacher);
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult GetTeacherDetails(int id)
        {
            Teacher teacher = DB.Teachers.Get(id);
            if (teacher == null) return HttpNotFound();
            return PartialView("_TeacherDetails", teacher);
        }

        [UserAccess(Access.ReadWrite)]
        public ActionResult Create()
        {
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View();
        }

        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Create(Teacher teacher, List<int> selectedCoursesId)
        {
            if (teacher.IsValid())
            {
                string code;
                do
                {
                    code = "CLG-420-" + new System.Random().Next(10000, 99999).ToString();
                } while (DB.Teachers.ToList().Any(t => t.Code == code));

                teacher.Code = code;
                DB.Teachers.Add(teacher);
                teacher.UpdateAllocations(selectedCoursesId);
                return RedirectToAction("Index");
            }
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View(teacher);
        }

        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(int id)
        {
            Teacher teacher = DB.Teachers.Get(id);
            if (teacher == null) return RedirectToAction("Index");
            ViewBag.Allocations = teacher.NextSessionCoursesToSelectList();
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View(teacher);
        }

        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(Teacher teacher, List<int> selectedCoursesId)
        {
            Teacher original = DB.Teachers.Get(teacher.Id);
            if (original == null) return RedirectToAction("Index");

            teacher.Code = original.Code;
            teacher.Avatar = original.Avatar;
            if (teacher.IsValid())
            {
                DB.Teachers.Update(teacher);
                teacher.UpdateAllocations(selectedCoursesId);
                return RedirectToAction("Details", new { id = teacher.Id });
            }
            ViewBag.Allocations = original.NextSessionCoursesToSelectList();
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View(teacher);
        }

        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Delete(int id)
        {
            Teacher teacher = DB.Teachers.Get(id);
            if (teacher != null)
            {
                teacher.DeleteAllAllocations();
                DB.Teachers.Delete(id);
            }
            return RedirectToAction("Index");
        }

        private List<Teacher> FilterTeachers(string search)
        {
            var teachers = DB.Teachers.ToList();

            if (!string.IsNullOrEmpty(search))
                teachers = teachers.FindAll(t => t.FullName.ToLower().Contains(search.ToLower()) || t.Code.ToLower().Contains(search.ToLower()));

            return teachers;
        }
    }
}
