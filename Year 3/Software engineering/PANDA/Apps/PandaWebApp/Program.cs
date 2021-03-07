using PandaWebApp.Data;

namespace PandaWebApp
{
    using SIS.MvcFramework;

    public static class Program
    {
        public static void Main()
        {
            using (var context = new PandaDbContext())
            {
                context.Database.EnsureCreated();
            }

            WebHost.Start(new Startup());
        }
    }
}
