using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bitcoin.Web.Startup))]
namespace Bitcoin.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
