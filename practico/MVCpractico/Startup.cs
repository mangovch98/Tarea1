using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCpractico.Startup))]
namespace MVCpractico
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
