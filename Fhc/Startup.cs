using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fhc.Startup))]
namespace Fhc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
