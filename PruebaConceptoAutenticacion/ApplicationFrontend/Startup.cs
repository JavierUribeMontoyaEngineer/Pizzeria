using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ApplicationFrontend.Startup))]
namespace ApplicationFrontend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
