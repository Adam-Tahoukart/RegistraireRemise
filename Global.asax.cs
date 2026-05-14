// Fichier qui demarre le site et ajoute les premiers usagers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using PFI.Models;

namespace PFI
{
    public class MvcApplication : System.Web.HttpApplication
    {
        // Demarre le site
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            SeedData();
        }

        // Ajoute les usagers de base
        private void SeedData()
        {
            if (DB.Users.ToList().Count == 0)
            {
                DB.Users.Add(new User { Email = "admin@app.net", Password = "password", Access = Access.Admin, Avatar = "admin" });
                DB.Users.Add(new User { Email = "super@app.net", Password = "password", Access = Access.ReadWrite, Avatar = "super" });
                DB.Users.Add(new User { Email = "user@app.net", Password = "password", Access = Access.ReadOnly, Avatar = "user" });
            }
        }
    }
}
