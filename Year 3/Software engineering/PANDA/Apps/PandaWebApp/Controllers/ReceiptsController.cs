using PandaWebApp.ViewModels.Receipts;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace PandaWebApp.Controllers
{
    public class ReceiptsController : BaseController
    {
        [Authorize]
        public IHttpResponse Index()
        {
            var user = this.Db.Users
                .FirstOrDefault(x => x.Username == this.User.Username);

            var userReceipts = user.Receipts
                .Select(x => new ReceiptViewModel
                {
                    Id = x.Id,
                    Fee = x.Fee,
                    IssuedOn = x.IssuedOn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                    Recipient = x.Recipient.Username
                })
                .ToList();

            var model = new IndexViewModel { Receipts = userReceipts };
            return this.View(model);
        }

        [Authorize]
        public IHttpResponse Details(int id)
        {
            var user = this.Db.Users
                .FirstOrDefault(x => x.Username == this.User.Username);

            var receipt = user.Receipts
                .FirstOrDefault(r => r.Id == id);

            var model = new ReceiptDetailsViewModel
            {
                Id = receipt.Id,
                DeliveryAddress = receipt.Package.ShippingAddress,
                IssuedOn = receipt.IssuedOn.ToString("dd/MM/yyyy", CultureInfo.InvariantCulture),
                PackageDescription = receipt.Package.Description,
                PackageWeight = receipt.Package.Weight,
                Recipient = receipt.Recipient.Username,
                Total = Math.Round(receipt.Fee, 2)
            };

            return this.View(model);
        }
    }
}
