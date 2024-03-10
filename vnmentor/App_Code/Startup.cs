using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(education.Startup))]
namespace education
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
