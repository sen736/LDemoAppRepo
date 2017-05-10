using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LDemoApp.Startup))]
namespace LDemoApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
