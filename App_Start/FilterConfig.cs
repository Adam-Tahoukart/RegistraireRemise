// Fichier qui ajoute le filtre pour les erreurs
using System.Web;
using System.Web.Mvc;

namespace PFI
{
    public class FilterConfig
    {
        // Ajoute les filtres globaux utilises par mvc
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
