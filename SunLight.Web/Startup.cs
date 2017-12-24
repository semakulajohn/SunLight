using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SunLight.Web.Startup))]
namespace SunLight.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
