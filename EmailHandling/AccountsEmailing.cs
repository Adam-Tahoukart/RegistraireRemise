using Newtonsoft.Json;
using PFI.Models;
using System;
using System.Linq;
using System.Web;

namespace EmailHandling
{
    public class UnverifiedEmail : DAL.Record
    {
        public void SetUser(User user = null)
        {
            if (user != null)
            {
                UserId = user.Id;
                Email = user.Email;
                VerificationCode = Guid.NewGuid().ToString();
            }
        }

        public string Email { get; set; }
        public string VerificationCode { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public User User => DAL.DB.Users.Get(UserId);
    }

    public class RenewPasswordCommand : DAL.Record
    {
        public void SetUser(User user = null)
        {
            if (user != null)
            {
                UserId = user.Id;
                VerificationCode = Guid.NewGuid().ToString();
            }
        }

        public string VerificationCode { get; set; }
        public int UserId { get; set; }

        [JsonIgnore]
        public User User => DAL.DB.Users.Get(UserId);
    }

    public static class AccountsEmailing
    {
        const string ApplicationName = "Registraire";

        public static string GetServerDomaine()
        {
            return HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority);
        }

        public static void SendEmailVerification(string ActionURL, User user)
        {
            UnverifiedEmail unverifiedEmail = new UnverifiedEmail();
            unverifiedEmail.SetUser(user);
            DAL.DB.UnverifiedEmails.Add(unverifiedEmail);

            string Link = @"<br/><a href='" + ActionURL + "?code=" + unverifiedEmail.VerificationCode + @"' >Confirmez votre inscription...</a>";
            string Subject = ApplicationName + " - Vérification de courriel...";
            string Body = "Bonjour " + DisplayName(user) + @",<br/><br/>";

            Body += @"Merci de vous être inscrit à " + ApplicationName + ". <br/>";
            Body += @"Pour utiliser votre compte vous devez confirmer votre inscription en cliquant sur le lien suivant : <br/>";
            Body += Link;
            Body += Footer();

            SMTP.SendEmail(DisplayName(user), user.Email, Subject, Body);
        }

        public static void SendEmailChangedVerification(string ActionURL, User user)
        {
            UnverifiedEmail unverifiedEmail = new UnverifiedEmail();
            unverifiedEmail.SetUser(user);
            DAL.DB.UnverifiedEmails.Add(unverifiedEmail);

            string Link = @"<br/><a href='" + ActionURL + "?code=" + unverifiedEmail.VerificationCode + @"' >Confirmez votre nouvelle adresse de courriel...</a>";
            string Subject = ApplicationName + " - Confirmation de changement de courriel...";
            string Body = "Bonjour " + DisplayName(user) + @",<br/><br/>";

            Body += @"Vous avez modifié votre adresse de courriel. <br/>";
            Body += @"Pour que ce changement soit pris en compte, vous devez confirmer cette adresse en cliquant sur le lien suivant : <br/>";
            Body += Link;
            Body += Footer();

            SMTP.SendEmail(DisplayName(user), unverifiedEmail.Email, Subject, Body);
        }

        public static void SendEmailRenewPasswordCommand(string ActionURL, string email)
        {
            User user = DAL.DB.Users.ToList().Where(u => u.Email == email).FirstOrDefault();
            if (user != null)
            {
                RenewPasswordCommand renewPasswordCommand = new RenewPasswordCommand();
                renewPasswordCommand.SetUser(user);
                DAL.DB.RenewPasswordCommands.Add(renewPasswordCommand);

                string Link = @"<br/><a href='" + ActionURL + "?code=" + renewPasswordCommand.VerificationCode + @"' >Entrez votre nouveau mot de passe...</a>";
                string Subject = ApplicationName + " - Renouvellement de mot de passe...";
                string Body = "Bonjour " + DisplayName(user) + @",<br/><br/>";

                Body += @"Vous avez demandé de renouveler votre mot de passe. <br/>";
                Body += @"Pour procéder, vous devez cliquer sur le lien suivant : <br/>";
                Body += Link;
                Body += Footer();

                SMTP.SendEmail(DisplayName(user), email, Subject, Body);
            }
        }

        public static void SendEmailUserStatusChanged(string message, User user)
        {
            string Subject = ApplicationName + " - Message du webmestre...";
            string Body = "Bonjour " + DisplayName(user) + @",<br/><br/>";

            Body += message;
            Body += Footer();

            SMTP.SendEmail(DisplayName(user), user.Email, Subject, Body);
        }

        private static string DisplayName(User user)
        {
            return string.IsNullOrEmpty(user.Email) ? "utilisateur" : user.Email;
        }

        private static string Footer()
        {
            return @"<br/><br/>Ce courriel a été généré automatiquement, veuillez ne pas y répondre." +
                   @"<br/><br/>Si vous éprouvez des difficultés ou s'il s'agit d'une erreur, veuillez le signaler à <a href='mailto:" +
                   SMTP.OwnerEmail + "'>" + SMTP.OwnerName + "</a> (Webmestre du site Registraire)";
        }
    }
}
