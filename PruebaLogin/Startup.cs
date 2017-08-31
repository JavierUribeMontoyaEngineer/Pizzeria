using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PruebaLogin.Startup))]
namespace PruebaLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
