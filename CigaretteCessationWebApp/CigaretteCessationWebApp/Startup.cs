using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CigaretteCessationWebApp.Startup))]
namespace CigaretteCessationWebApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
