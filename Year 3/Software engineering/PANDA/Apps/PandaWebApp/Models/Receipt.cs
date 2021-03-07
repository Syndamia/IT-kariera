using System;

namespace PandaWebApp.Models
{
    public class Receipt
    {
        public int Id { get; set; }

        public decimal Fee { get; set; }

        public DateTime IssuedOn { get; set; } = DateTime.UtcNow;

        public int? RecipientId { get; set; }
        public virtual User Recipient { get; set; }

        public int? PackageId { get; set; }
        public virtual Package Package { get; set; }
    }
}
