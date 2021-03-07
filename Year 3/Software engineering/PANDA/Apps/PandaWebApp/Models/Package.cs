using PandaWebApp.Models.Enums;
using System;
using System.Collections.Generic;

namespace PandaWebApp.Models
{
    public class Package
    {
        public int Id { get; set; }

        public string Description { get; set; }

        public decimal Weight { get; set; }

        public string ShippingAddress { get; set; }

        public Status Status { get; set; }

        public DateTime? EstimatedDeliveryDate { get; set; }

        public int RecipientId { get; set; }
        public virtual User Recipient { get; set; }

        public virtual ICollection<Receipt> Receipts { get; set; } = new HashSet<Receipt>();
    }
}
