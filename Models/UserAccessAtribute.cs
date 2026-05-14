// Filtre qui verifie les droits de l usager
using System.Web.Mvc;

namespace PFI.Models
{
    public class UserAccessAttribute : ActionFilterAttribute
    {
        private Access _requiredAccess;

        // Garde le nom du fichier
        public UserAccessAttribute(Access access)
        {
            _requiredAccess = access;
        }

        // Verifie la session avant de laisser mvc executer l'action
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var session = filterContext.HttpContext.Session;

            if (session["access"] == null)
            {
                filterContext.Result = new RedirectResult("/Accounts/Login?message=Veuillez vous connecter.&success=false");
                return;
            }

            Access userAccess = (Access)session["access"];

            if (userAccess < _requiredAccess)
            {
                filterContext.Result = new RedirectResult("/Accounts/Login?message=Acces refuse.&success=false");
                return;
            }

            base.OnActionExecuting(filterContext);
        }
    }
}