using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AuthDemo01.Startup))]
namespace AuthDemo01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
