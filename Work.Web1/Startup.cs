using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Work.Web1.Startup))]
namespace Work.Web1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
