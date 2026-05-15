using PFI.Models;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class UsersController : Controller
    {
        [UserAccess(Access.Admin)]
        public ActionResult Index()
        {
            return View(DB.Users.ToList());
        }

        [UserAccess(Access.Admin)]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [UserAccess(Access.Admin)]
        public ActionResult Create(User user)
        {
            if (user.IsValid())
            {
                bool emailExists = DB.Users.ToList().Exists(u => u.Email == user.Email);
                if (emailExists)
                {
                    ViewBag.Error = "Ce courriel est deja utilise.";
                    return View(user);
                }
                DB.Users.Add(user);
                return RedirectToAction("Index");
            }
            ViewBag.Error = "Veuillez remplir tous les champs.";
            return View(user);
        }

        [UserAccess(Access.Admin)]
        public ActionResult Edit(int id)
        {
            User user = DB.Users.Get(id);
            if (user == null) return RedirectToAction("Index");
            return View(user);
        }

        [HttpPost]
        [UserAccess(Access.Admin)]
        public ActionResult Edit(User user)
        {
            if (user.IsValid())
            {
                DB.Users.Update(user);
                return RedirectToAction("Index");
            }
            ViewBag.Error = "Veuillez remplir tous les champs.";
            return View(user);
        }

        [HttpPost]
        [UserAccess(Access.Admin)]
        public ActionResult Delete(int id)
        {
            User user = DB.Users.Get(id);
            if (user != null)
                DB.Users.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
