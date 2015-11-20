using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SWDXB2015.Startup))]
namespace SWDXB2015
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
