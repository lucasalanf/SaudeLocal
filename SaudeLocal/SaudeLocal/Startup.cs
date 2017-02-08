using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SaudeLocal.Startup))]
namespace SaudeLocal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
