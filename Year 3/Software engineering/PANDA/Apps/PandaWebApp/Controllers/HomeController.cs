namespace PandaWebApp.Controllers
{
    using PandaWebApp.Models.Enums;
    using PandaWebApp.ViewModels.Home;
    using SIS.HTTP.Responses;
    using SIS.MvcFramework;
    using System.Linq;

    public class HomeController : BaseController
    {
        public IHttpResponse Index()
        {
            if (this.User.IsLoggedIn)
            {
                var shipped = this.Db.Packages
                    .Where(p => p.Status == Status.Shipped && p.Recipient.Username == this.User.Username)
                    .Select(p => new PackageViewModel
                    {
                        Id = p.Id,
                        Description = p.Description
                    })
                    .ToList();

                var pending = this.Db.Packages
                    .Where(p => p.Status == Status.Pending && p.Recipient.Username == this.User.Username)
                    .Select(p => new PackageViewModel
                    {
                        Id = p.Id,
                        Description = p.Description
                    })
                    .ToList();

                var delivered = this.Db.Packages
                    .Where(p => p.Status == Status.Delivered && p.Recipient.Username == this.User.Username)
                    .Select(p => new PackageViewModel
                    {
                        Id = p.Id,
                        Description = p.Description
                    })
                    .ToList();

                var packagesInfoViewModel = new PackagesInfoViewModel
                {
                    Pending = pending,
                    Shipped = shipped,
                    Delivered = delivered
                };

                var model = new LoggedInViewModel { PackageInfo = packagesInfoViewModel };

                return this.View("/Home/IndexLoggedIn", model);
            }

            return this.View();
        }
    }
}
