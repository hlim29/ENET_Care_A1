using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ENET_Care_New.Startup))]
namespace ENET_Care_New
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
