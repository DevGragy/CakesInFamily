using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Login3Mayo.Startup))]
namespace Login3Mayo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
