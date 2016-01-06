using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ZuluTrade.Startup))]
namespace ZuluTrade
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
