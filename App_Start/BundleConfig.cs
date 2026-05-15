// Fichier qui groupe les scripts et les fichiers CSS
using System.Web;
using System.Web.Optimization;

namespace PFI
{
    public class BundleConfig
    {
        // Ajoute les scripts et les styles
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/scripts/selections.js",
                "~/scripts/SiteScripts.js"));

            bundles.Add(new StyleBundle("~/bundles/css").Include(
                "~/Content/site.css",
                "~/Content/Accounts.css",
                "~/Content/Students.css",
                "~/Content/Courses.css",
                "~/Content/Teachers.css",
                "~/Content/Selections.css"));
        }
    }
}
