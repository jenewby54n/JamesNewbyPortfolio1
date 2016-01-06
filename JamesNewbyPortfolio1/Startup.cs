using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JamesNewbyPortfolio1.Startup))]
namespace JamesNewbyPortfolio1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
