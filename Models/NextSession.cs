// Fichier qui trouve la prochaine session
using System;
using System.Collections.Generic;
using System.Web;

namespace PFI.Models
{
    public sealed class NextSession
    {
        public const int January = 1;
        public const int August = 8;

        private static readonly NextSession instance = new NextSession();
        public static NextSession Instance => instance;

        // Garde la date choisie
        public static DateTime CurrentDate
        {
            get
            {
                if (HttpContext.Current != null && HttpContext.Current.Session["currentDate"] != null)
                    return (DateTime)HttpContext.Current.Session["currentDate"];
                return DateTime.Now;
            }
            set
            {
                if (HttpContext.Current != null)
                    HttpContext.Current.Session["currentDate"] = value;
            }
        }

        // Donne les sessions valides
        public static List<int> ValidSessions
        {
            get
            {
                if (CurrentDate.Month > January && CurrentDate.Month <= August)
                    return new List<int> { 1, 3, 5 };

                return new List<int> { 2, 4, 6 };
            }
        }

        // Trouve l annee
        public static int Year
        {
            get
            {
                int value = CurrentDate.Year;
                if (CurrentDate.Month > August && CurrentDate.Month <= 12)
                    value++;
                return value;
            }
        }

        // Donne le nom court de la session
        public static string ShortCaption => (ValidSessions.Contains(1) ? "Automne " : "Hiver ") + Year;
        // Donne le nom complet de la session
        public static string Caption => "Session " + ShortCaption;
    }
}
