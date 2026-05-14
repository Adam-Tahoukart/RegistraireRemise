// Modele pour les usagers
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFI.Models
{
    // Liste les droits possibles
    public enum Access { ReadOnly, ReadWrite, Admin }

    public class User : Record
    {
        // Courriel de connexion
        public string Email { get; set; }
        // Mot de passe
        public string Password { get; set; }
        // Droit de l usager
        public Access Access { get; set; }
        // Image de l usager
        public string Avatar { get; set; }

        // Verifie que le courriel et le mot de passe sont remplis
        // Verifie que les informations obligatoires de l'usager sont remplies
        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }
    }
}