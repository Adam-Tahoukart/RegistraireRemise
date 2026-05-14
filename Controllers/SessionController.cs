// Controleur pour changer la session courante
using PFI.Models;
using System;
using System.Web.Mvc;

namespace PFI.Controllers
{
    public class SessionController : Controller
    {
        // Affiche le formulaire
        [UserAccess(Access.ReadOnly)]
        public ActionResult Edit()
        {
            Session["lastController"] = Request.UrlReferrer != null ?
                Request.UrlReferrer.Segments[1].Replace("/", "") : "Students";
            return View();
        }

        // Modifie les infos
        [HttpPost]
        [UserAccess(Access.ReadOnly)]
        public ActionResult Edit(int year, string season)
        {
            int month = season == "Automne" ? 9 : 2;
            NextSession.CurrentDate = new DateTime(year, month, 1);
            string lastController = Session["lastController"] as string ?? "Students";
            return RedirectToAction("Index", lastController);
        }
    }
}