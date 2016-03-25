using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Wakatest.Startup))]
namespace Wakatest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
