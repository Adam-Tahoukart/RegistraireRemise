// Controleur pour la connexion et la deconnexion
using PFI.Models;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class AccountsController : Controller
    {
        // Affiche la page de connexion avec un message optionnel
        public ActionResult Login(string message = "", bool success = true)
        {
            ViewBag.Message = message;
            ViewBag.Success = success;
            return View();
        }

        // Verifie le courriel et le mot de passe
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(string email, string password)
        {
            User user = DB.Users.ToList().Find(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                Session["id"] = user.Id;
                Session["email"] = user.Email;
                Session["access"] = user.Access;
                return RedirectToAction("Index", "Students");
            }
            ViewBag.Message = "Courriel ou mot de passe invalide.";
            ViewBag.Success = false;
            return View();
        }

        // Affiche la page de creation de compte
        public ActionResult Subscribe()
        {
            return View(new User());
        }

        // Cree un compte utilisateur en lecture seule
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Subscribe(User user, string confirmPassword)
        {
            if (user == null)
            {
                ViewBag.Error = "Veuillez remplir tous les champs.";
                return View(new User());
            }

            user.Email = (user.Email ?? "").Trim();
            user.Password = (user.Password ?? "").Trim();
            confirmPassword = (confirmPassword ?? "").Trim();
            user.Access = Access.ReadOnly;

            if (!user.IsValid())
            {
                ViewBag.Error = "Veuillez remplir tous les champs.";
                return View(user);
            }

            if (user.Password != confirmPassword)
            {
                ViewBag.Error = "Les mots de passe ne correspondent pas.";
                return View(user);
            }

            bool emailExists = DB.Users.ToList().Exists(u => u.Email.ToLower() == user.Email.ToLower());
            if (emailExists)
            {
                ViewBag.Error = "Ce courriel est deja utilise.";
                return View(user);
            }

            DB.Users.Add(user);
            return RedirectToAction("Login", new { message = "Creation de compte effectuee avec succes. Vous pouvez maintenant vous connecter.", success = true });
        }

        // Ferme la session
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Login");
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult EditProfil()
        {
            int id = (int)Session["id"];
            User user = DB.Users.Get(id);
            if (user == null) return RedirectToAction("Login");
            return View(user);
        }

        [HttpPost]
        [UserAccess(Access.ReadOnly)]
        public ActionResult EditProfil(User user)
        {
            int id = (int)Session["id"];
            User original = DB.Users.Get(id);
            if (original == null) return RedirectToAction("Login");

            original.Email = user.Email;
            original.Password = user.Password;
            original.Avatar = user.Avatar;

            if (original.IsValid())
            {
                DB.Users.Update(original);
                Session["email"] = original.Email;
                return RedirectToAction("Index", "Students");
            }

            ViewBag.Error = "Veuillez remplir tous les champs.";
            return View(original);
        }

        [UserAccess(Access.Admin)]
        public ActionResult LoginsJournal()
        {
            return View();
        }

        [UserAccess(Access.Admin)]
        public ActionResult EventsJournal()
        {
            return View();
        }

        [UserAccess(Access.ReadOnly)]
        public ActionResult About()
        {
            return View();
        }
    }
}
