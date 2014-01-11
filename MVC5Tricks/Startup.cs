using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVC5Tricks.Startup))]
namespace MVC5Tricks
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
