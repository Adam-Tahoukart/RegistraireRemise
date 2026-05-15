using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PFI.Models
{
    public enum Access { ReadOnly, ReadWrite, Admin }

    public class User : Record
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Access Access { get; set; }
        public string Avatar { get; set; }

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Email) && !string.IsNullOrEmpty(Password);
        }
    }
}
