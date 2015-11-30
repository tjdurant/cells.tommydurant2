using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cells.tommydurant2.Startup))]
namespace cells.tommydurant2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
