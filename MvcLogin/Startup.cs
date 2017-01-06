using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcLogin.Startup))]
namespace MvcLogin
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
