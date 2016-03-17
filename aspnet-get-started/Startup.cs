using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(aspnet_get_started.Startup))]
namespace aspnet_get_started
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
