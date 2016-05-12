using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KalahariVisuals.Startup))]
namespace KalahariVisuals
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
