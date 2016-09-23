using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcUrlEncryption.Startup))]
namespace MvcUrlEncryption
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
