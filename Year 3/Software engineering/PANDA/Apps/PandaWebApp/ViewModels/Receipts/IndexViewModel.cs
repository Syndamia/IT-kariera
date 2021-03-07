using System;
using System.Collections.Generic;
using System.Text;

namespace PandaWebApp.ViewModels.Receipts
{
    public class IndexViewModel
    {
        public ICollection<ReceiptViewModel> Receipts { get; set; }
    }
}
