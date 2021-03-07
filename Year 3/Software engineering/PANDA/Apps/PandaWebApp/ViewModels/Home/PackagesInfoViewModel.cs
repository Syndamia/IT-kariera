using System.Collections.Generic;

namespace PandaWebApp.ViewModels.Home
{
    public class PackagesInfoViewModel
    {
        public ICollection<PackageViewModel> Pending { get; set; }

        public ICollection<PackageViewModel> Shipped { get; set; }

        public ICollection<PackageViewModel> Delivered { get; set; }
    }
}
