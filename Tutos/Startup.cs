using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tutos.Startup))]
namespace Tutos
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
