using Microsoft.EntityFrameworkCore;
using PandaWebApp.Models;
using PandaWebApp.Models.Enums;
using PandaWebApp.ViewModels.Packages;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System;
using System.Globalization;
using System.Linq;

namespace PandaWebApp.Controllers
{
    public class PackagesController : BaseController
    {
        [Authorize]
        public IHttpResponse Details(int id)
        {
            var dbPackage = this.Db.Packages
                .Include(p => p.Recipient)
                .FirstOrDefault(p => p.Id == id);

            string date;

            if (dbPackage.Status == Status.Pending)
            {
                date = "N/A";
            }
            else if (dbPackage.Status == Status.Shipped)
            {
                date = dbPackage.EstimatedDeliveryDate.Value.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture);
            }
            else
            {
                date = "Delivered";
            }

            var model = new PackageDetailsViewModel
            {
                Description = dbPackage.Description,
                EstimatedDeliveryDate = date,
                Status = dbPackage.Status.ToString(),
                Recipient = dbPackage.Recipient.Username,
                ShippingAddress = dbPackage.ShippingAddress,
                Weight = dbPackage.Weight

            };

            return this.View(model);
        }

        [Authorize("Admin")]
        public IHttpResponse Create()
        {
            var users = this.Db.Users.Select(u => u.Username).ToList();

            var model = new DropListViewModel
            {
                Recipients = users
            };

            return this.View(model);
        }

        [Authorize("Admin")]
        [HttpPost]
        public IHttpResponse Create(CreatePackageViewModel model)
        {
            var recipient = this.Db.Users
                .FirstOrDefault(x => x.Username == this.User.Username);

            var package = new Package
            {
                Description = model.Description,
                Weight = model.Weight,
                ShippingAddress = model.ShippingAddress,
                Recipient = recipient,
                Status = Status.Pending
            };

            this.Db.Packages.Add(package);
            this.Db.SaveChanges();

            return this.Redirect("/");
        }

        [Authorize("Admin")]
        public IHttpResponse Pending()
        {
            var packages = this.Db.Packages
                .Include(p => p.Recipient)
                .Where(p => p.Status == Status.Pending)
                .Select(p => new StatusViewModel
                {
                    Id = p.Id,
                    Description = p.Description,
                    Recipient = p.Recipient.Username,
                    ShippingAddress = p.ShippingAddress,
                    Weight = p.Weight
                })
                .ToList();

            var model = new IndexPakagesViewModel{ Packages = packages };

            return this.View(model);
        }

        [Authorize("Admin")]
        public IHttpResponse Shipped()
        {
            var packages = this.Db.Packages
                .Include(p => p.Recipient)
                .Where(p => p.Status == Status.Shipped)
                .Select(p => new StatusViewModel
                {
                    Id = p.Id,
                    Description = p.Description,
                    Recipient = p.Recipient.Username,
                    ShippingAddress = p.ShippingAddress,
                    Weight = p.Weight
                })
                .ToList();

            var model = new IndexPakagesViewModel { Packages = packages };

            return this.View(model);
        }

        [Authorize("Admin")]
        public IHttpResponse Ship(int id)
        {
            var package = this.Db.Packages
                .FirstOrDefault(p => p.Id == id);

            package.Status = Status.Shipped;
            package.EstimatedDeliveryDate.Value.AddDays(new Random().Next(20, 41));

            this.Db.SaveChanges();

            return this.Redirect("/");
        }

        [Authorize("Admin")]
        public IHttpResponse Deliver(int id)
        {
            var package = this.Db.Packages
                .FirstOrDefault(p => p.Id == id);

            package.Status = Status.Acquired;

            this.Db.SaveChanges();

            return this.Redirect("/");
        }
    }
}
