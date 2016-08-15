using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShareImmediate.Startup))]
namespace ShareImmediate
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
