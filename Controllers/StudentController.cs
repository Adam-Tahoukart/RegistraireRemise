using PFI.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class StudentsController : Controller
    {
        [UserAccess(Access.ReadOnly)]
        public ActionResult Index(string search = "", int year = 0)
        {
            Session["lastController"] = "Students";
            Session["lastAction"] = "Index";

            ViewBag.Search = search;
            ViewBag.Year = year;
            ViewBag.YearsList = DB.Students.ToList().Select(s => s.Year).Distinct().OrderByDescending(y => y).ToList();

            return View(FilterStudents(search, year));
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult GetStudentsList(string search = "", int year = 0)
        {
            ViewBag.YearsList = DB.Students.ToList().Select(s => s.Year).Distinct().OrderByDescending(y => y).ToList();
            return PartialView("_StudentsList", FilterStudents(search, year));
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult Details(int id)
        {
            Student student = DB.Students.Get(id);
            if (student == null) return RedirectToAction("Index");
            return View(student);
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult GetStudentDetails(int id)
        {
            Student student = DB.Students.Get(id);
            if (student == null) return HttpNotFound();
            return PartialView("_StudentDetails", student);
        }

        [UserAccess(Access.ReadWrite)]
        public ActionResult Create()
        {
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View();
        }

        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Create(Student student, List<int> selectedCoursesId)
        {
            if (student.IsValid())
            {
                string code;
                do
                {
                    code = NextSession.Year.ToString() + new System.Random().Next(100000, 999999).ToString();
                } while (DB.Students.ToList().Any(s => s.Code == code));

                student.Code = code;
                DB.Students.Add(student);
                student.UpdateRegistrations(selectedCoursesId);
                return RedirectToAction("Index");
            }
            ViewBag.Errors = student.ValidationErrors;
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View(student);
        }

        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(int id)
        {
            Student student = DB.Students.Get(id);
            if (student == null) return RedirectToAction("Index");
            ViewBag.Registrations = student.NextSessionCoursesToSelectList();
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View(student);
        }

        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Edit(Student student, List<int> selectedCoursesId)
        {
            Student original = DB.Students.Get(student.Id);
            if (original == null) return RedirectToAction("Index");

            student.Code = original.Code;
            if (student.IsValid())
            {
                DB.Students.Update(student);
                student.UpdateRegistrations(selectedCoursesId);
                return RedirectToAction("Details", new { id = student.Id });
            }
            ViewBag.Errors = student.ValidationErrors;
            ViewBag.Registrations = original.NextSessionCoursesToSelectList();
            ViewBag.Courses = Course.NextSessionToSelectList();
            return View(student);
        }

        [HttpPost]
        [UserAccess(Access.ReadWrite)]
        public ActionResult Delete(int id)
        {
            Student student = DB.Students.Get(id);
            if (student != null)
            {
                student.DeleteAllRegistrations();
                DB.Students.Delete(id);
            }
            return RedirectToAction("Index");
        }

        private List<Student> FilterStudents(string search, int year)
        {
            var students = DB.Students.ToList();

            if (!string.IsNullOrEmpty(search))
                students = students.Where(s => s.FullName.ToLower().Contains(search.ToLower()) || s.Code.Contains(search)).ToList();

            if (year > 0)
                students = students.Where(s => s.Year == year).ToList();

            return students;
        }
    }
}
