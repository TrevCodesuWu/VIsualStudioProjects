using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RolesApplication.Startup))]
namespace RolesApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
