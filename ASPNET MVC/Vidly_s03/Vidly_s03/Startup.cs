using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Vidly_s03.Startup))]
namespace Vidly_s03
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
