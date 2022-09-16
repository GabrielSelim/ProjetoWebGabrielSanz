using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SiteGabriel.AppMvc.Startup))]
namespace SiteGabriel.AppMvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
