// Controleur pour gerer les usagers
using PFI.Models;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class UsersController : Controller
    {
        // Affiche la liste
        [UserAccess(Access.Admin)]
        public ActionResult Index()
        {
            return View(DB.Users.ToList());
        }

        // Affiche le formulaire
        [UserAccess(Access.Admin)]
        public ActionResult Create()
        {
            return View();
        }

        // Ajoute un nouvel element
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

        // Affiche le formulaire
        [UserAccess(Access.Admin)]
        public ActionResult Edit(int id)
        {
            User user = DB.Users.Get(id);
            if (user == null) return RedirectToAction("Index");
            return View(user);
        }

        // Modifie les infos
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

        // Supprime un element
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