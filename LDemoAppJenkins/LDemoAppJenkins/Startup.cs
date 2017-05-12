using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LDemoAppJenkins.Startup))]
namespace LDemoAppJenkins
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
