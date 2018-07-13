using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Nexus.Website.Startup))]
namespace Nexus.Website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
