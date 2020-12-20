using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BuildersExchangeProject.Startup))]
namespace BuildersExchangeProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
