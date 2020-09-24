using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GalaxyStoreMVC.Startup))]
namespace GalaxyStoreMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
