using PandaWebApp.Models;
using PandaWebApp.Models.Enums;
using PandaWebApp.ViewModels.Users;
using SIS.HTTP.Cookies;
using SIS.HTTP.Responses;
using SIS.MvcFramework;
using SIS.MvcFramework.Services;
using System.Linq;

namespace PandaWebApp.Controllers
{
    public class UsersController : BaseController
    {
        private readonly IHashService hashService;

        public UsersController(IHashService hashService)
        {
            this.hashService = hashService;
        }

        public IHttpResponse Login()
        {
            if (this.User.IsLoggedIn)
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        public IHttpResponse Login(LoginViewModel model)
        {
            var hashedPassword = this.hashService.Hash(model.Password);

            var user = this.Db.Users
                .FirstOrDefault(x => x.Username == model.Username && x.Password == hashedPassword);

            if (user == null)
            {
                return this.BadRequestErrorWithView("Invalid Username or Password.");
            }

            var mvcUser = new MvcUserInfo
            {
                Username = user.Username,
                Role = user.Role.ToString(),
                Info = user.Email
            };

            var cookieContent = this.UserCookieService.GetUserCookie(mvcUser);
            var cookie = new HttpCookie(".auth-cakes", cookieContent, 7) { HttpOnly = true };
            this.Response.Cookies.Add(cookie);

            return this.Redirect("/");
        }

        public IHttpResponse Register()
        {
            if (this.User.IsLoggedIn)
            {
                return this.Redirect("/");
            }

            return this.View();
        }

        [HttpPost]
        public IHttpResponse Register(RegisterViewModel model)
        {
            if (model.Password != model.ConfirmPassword)
            {
                return this.BadRequestError("Passwords do not match");
            }

            var hashedPassword = this.hashService.Hash(model.Password);

            if (this.Db.Users.Any(x => x.Username == model.Username && x.Password == hashedPassword))
            {
                return this.BadRequestErrorWithView($"User {model.Username} already exists.", this.View());
            }

            var user = new User
            {
                Username = model.Username.Trim(),
                Password = hashedPassword,
                Email = model.Email.Trim()
            };

            if (!this.Db.Users.Any())
            {
                user.Role = Role.Admin;
            }
            else
            {
                user.Role = Role.User;
            }

            this.Db.Users.Add(user);
            this.Db.SaveChanges();

            return this.Redirect("/users/login");
        }

        [Authorize]
        public IHttpResponse Logout()
        {
            if (!this.Request.Cookies.ContainsCookie(".auth-cakes"))
            {
                return this.Redirect("/");
            }

            var cookie = this.Request.Cookies.GetCookie(".auth-cakes");
            cookie.Delete();
            this.Response.Cookies.Add(cookie);

            return this.Redirect("/");
        }
    }
}
