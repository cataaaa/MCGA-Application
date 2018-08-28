using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MCGA.website.Startup))]
namespace MCGA.website
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
