using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KursMVC.Startup))]
namespace KursMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
