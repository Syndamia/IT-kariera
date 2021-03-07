using PandaWebApp.Models.Enums;
using System.Collections.Generic;

namespace PandaWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        public Role Role { get; set; }

        public virtual ICollection<Package> Packages { get; set; } = new HashSet<Package>();

        public virtual ICollection<Receipt> Receipts { get; set; } = new HashSet<Receipt>();
    }
}
