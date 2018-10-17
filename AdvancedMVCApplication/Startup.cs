using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AdvancedMVCApplication.Startup))]
namespace AdvancedMVCApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
